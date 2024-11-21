using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Controllers;

namespace TravelExperts.Views
{
    public partial class BaseUserControl : UserControl
    {
        //Declaring controls
        private FlowLayoutPanel panel_Top;
        private TableLayoutPanel tableLayoutPanel;
        protected DataGridView dataGridView_Base;
        protected TextBox textBox_Base1;

        //Logic to set the flag for the MainForm
        // This will allow the Buttons shared between AgentControl and AgencyControl to know which CRUD operation to perform.
        public enum ActionFlag
        {
            None,
            AgentControl,
            AgencyControl
        }

        private ActionFlag currentActionFlag = ActionFlag.None;
        public ActionFlag CurrentActionFlag
        {
            get { return currentActionFlag; }
            set { currentActionFlag = value; }
        }

        // Event Handler properties
        public event EventHandler AddButtonClicked;
        public event EventHandler ModifyButtonClicked;
        public event EventHandler DeleteButtonClicked;

        //Button properties
        protected Button button_Add;
        protected Button button_Modify;
        protected Button button_Delete;

        public BaseUserControl()
        {
            InitializeComponent();
            InitializeLayout();
            InitializeControls();

            this.Width = 1000;
            this.Height = 600;
        }

        private void InitializeLayout()
        {
            // Layout controls, new concept to me, need to research more.
            panel_Top = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 50,
                FlowDirection = FlowDirection.LeftToRight,
            };

            tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                AutoSize = true
            };

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

            this.Controls.Add(tableLayoutPanel);
        }

        private void InitializeControls()
        {
            Panel centerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                Anchor = AnchorStyles.None,
            };
            //Datagrid view
            dataGridView_Base = new DataGridView()
            {
                Width = 744,
                Height = 250,
                AutoSize = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false

            };
            centerPanel.Controls.Add(dataGridView_Base);
            tableLayoutPanel.Controls.Add(centerPanel, 0, 0);

            //Textboxes
            textBox_Base1 = CreateTextBox("Filter Search");
            tableLayoutPanel.Controls.Add(textBox_Base1, 0, 1);



            //Buttons
            button_Add = new Button { Text = "Add", BackColor = Color.Gray, Dock = DockStyle.Fill };
            button_Modify = new Button { Text = "Modify", BackColor = Color.Gray, Dock = DockStyle.Fill };
            button_Delete = new Button { Text = "Delete", BackColor = Color.Gray, Dock = DockStyle.Fill };

            button_Add.Click += Button_Add_Click;
            button_Modify.Click += Button_Modify_Click;
            button_Delete.Click += Button_Delete_Click;

            //Eventhandlers for styling
            StylingButtonEventHandler(button_Add, Color.LightGreen);
            StylingButtonEventHandler(button_Modify, Color.Yellow);
            StylingButtonEventHandler(button_Delete, Color.Red);

            tableLayoutPanel.Controls.Add(button_Add, 0, 2);
            tableLayoutPanel.Controls.Add(button_Modify, 0, 3);
            tableLayoutPanel.Controls.Add(button_Delete, 0, 4);
        }


        private TextBox CreateTextBox(string placeholderText)
        {
            return new TextBox { PlaceholderText = placeholderText, Dock = DockStyle.Fill };
        }





        // Event Handlers
        private void StylingButtonEventHandler(Button button, Color baseColor)
        {
            Color originalColor = Color.Gray;

            button.BackColor = baseColor;

            button.MouseEnter += (s, e) => button.BackColor = ControlPaint.Light(baseColor);
            button.MouseLeave += (s, e) => button.BackColor = originalColor;
            button.MouseDown += (s, e) => button.BackColor = ControlPaint.Dark(baseColor);
            button.MouseUp += (s, e)  => button.BackColor = ControlPaint.Light(baseColor);
        }

        private void Button_Delete_Click(object? sender, EventArgs e)
        {
            
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Button_Modify_Click(object? sender, EventArgs e)
        {
            ModifyButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Button_Add_Click(object? sender, EventArgs e)
        {
            AddButtonClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
