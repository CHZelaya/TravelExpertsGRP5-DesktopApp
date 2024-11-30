import os
import re

def extract_method_signatures(file_content):
    # Use regex to find method signatures
    method_pattern = re.compile(r'public\s+(?:static\s+)?\w+\s+(\w+)\s*\([^\)]*\)')
    return method_pattern.findall(file_content)

def extract_properties(file_content):
    # Use regex to find properties
    property_pattern = re.compile(r'public\s+\w+\s+(\w+)\s*{\s*get;\s*set;\s*}')
    return property_pattern.findall(file_content)

def analyze_directory(directory):
    analysis = {}
    for root, _, files in os.walk(directory):
        for file in files:
            if file.endswith(".cs"):
                file_path = os.path.join(root, file)
                with open(file_path, 'r', encoding='utf-8') as f:
                    content = f.read()
                    methods = extract_method_signatures(content)
                    properties = extract_properties(content)
                    if methods or properties:
                        analysis[file_path] = {
                            'methods': methods,
                            'properties': properties
                        }
    return analysis

def print_analysis(analysis):
    for file_path, details in analysis.items():
        print(f"\nFile: {file_path}")
        if details['methods']:
            print("  Methods:")
            for method in details['methods']:
                print(f"    - {method}")
        if details['properties']:
            print("  Properties:")
            for prop in details['properties']:
                print(f"    - {prop}")

if __name__ == "__main__":
    # Specify the root directory of the project
    project_root = "."
    analysis_result = analyze_directory(project_root)
    print_analysis(analysis_result)
