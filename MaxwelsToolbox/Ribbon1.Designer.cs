namespace MaxwelsToolbox
{
	partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Ribbon1()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
                        this.tab1 = this.Factory.CreateRibbonTab();
                        this.group1 = this.Factory.CreateRibbonGroup();
                        this.button1 = this.Factory.CreateRibbonButton();
                        this.cbCrop = this.Factory.CreateRibbonCheckBox();
                        this.cbSize = this.Factory.CreateRibbonCheckBox();
                        this.cbHeight = this.Factory.CreateRibbonCheckBox();
                        this.cbRotation = this.Factory.CreateRibbonCheckBox();
                        this.cbPosition = this.Factory.CreateRibbonCheckBox();
                        this.button2 = this.Factory.CreateRibbonButton();
                        this.button3 = this.Factory.CreateRibbonButton();
                        this.button4 = this.Factory.CreateRibbonButton();
                        this.tab1.SuspendLayout();
                        this.group1.SuspendLayout();
                        // 
                        // tab1
                        // 
                        this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
                        this.tab1.Groups.Add(this.group1);
                        this.tab1.Label = "Maxwel\'s Toolbox";
                        this.tab1.Name = "tab1";
                        // 
                        // group1
                        // 
                        this.group1.Items.Add(this.button1);
                        this.group1.Items.Add(this.cbCrop);
                        this.group1.Items.Add(this.cbSize);
                        this.group1.Items.Add(this.cbHeight);
                        this.group1.Items.Add(this.cbRotation);
                        this.group1.Items.Add(this.cbPosition);
                        this.group1.Items.Add(this.button2);
                        this.group1.Items.Add(this.button3);
                        this.group1.Items.Add(this.button4);
                        this.group1.Label = "Maxwel\'s Toolbox";
                        this.group1.Name = "group1";
                        // 
                        // button1
                        // 
                        this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
                        this.button1.Label = "Pick Properties";
                        this.button1.Name = "button1";
                        this.button1.ShowImage = true;
                        this.button1.SuperTip = "Picks up properties of an image or shape.";
                        this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.copyImg_Click);
                        // 
                        // cbCrop
                        // 
                        this.cbCrop.Checked = true;
                        this.cbCrop.Label = "Crop";
                        this.cbCrop.Name = "cbCrop";
                        // 
                        // cbSize
                        // 
                        this.cbSize.Checked = true;
                        this.cbSize.Label = "Width";
                        this.cbSize.Name = "cbSize";
                        // 
                        // cbHeight
                        // 
                        this.cbHeight.Checked = true;
                        this.cbHeight.Label = "Height";
                        this.cbHeight.Name = "cbHeight";
                        // 
                        // cbRotation
                        // 
                        this.cbRotation.Checked = true;
                        this.cbRotation.Label = "Rotation";
                        this.cbRotation.Name = "cbRotation";
                        // 
                        // cbPosition
                        // 
                        this.cbPosition.Checked = true;
                        this.cbPosition.Label = "Position";
                        this.cbPosition.Name = "cbPosition";
                        // 
                        // button2
                        // 
                        this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
                        this.button2.Label = "Apply Properties";
                        this.button2.Name = "button2";
                        this.button2.ScreenTip = "Applies properties to selected image or shape.";
                        this.button2.ShowImage = true;
                        this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.pasteImg_Click);
                        // 
                        // button3
                        // 
                        this.button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
                        this.button3.Label = "Reset Img";
                        this.button3.Name = "button3";
                        this.button3.ScreenTip = "Resets the selected image.";
                        this.button3.ShowImage = true;
                        this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.resetImg_Click);
                        // 
                        // button4
                        // 
                        this.button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
                        this.button4.Label = "Show Properties";
                        this.button4.Name = "button4";
                        this.button4.ScreenTip = "Displays the properties of the image.";
                        this.button4.ShowImage = true;
                        this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button4_Click);
                        // 
                        // Ribbon1
                        // 
                        this.Name = "Ribbon1";
                        this.RibbonType = "Microsoft.PowerPoint.Presentation";
                        this.Tabs.Add(this.tab1);
                        this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
                        this.tab1.ResumeLayout(false);
                        this.tab1.PerformLayout();
                        this.group1.ResumeLayout(false);
                        this.group1.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbCrop;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbPosition;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbSize;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbRotation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbHeight;
	}

	partial class ThisRibbonCollection
	{
		internal Ribbon1 Ribbon1
		{
			get { return this.GetRibbon<Ribbon1>(); }
		}
	}
}
