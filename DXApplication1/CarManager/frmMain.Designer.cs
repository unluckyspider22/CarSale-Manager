namespace CarManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCarLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaffLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnManagerLoad = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnLogin1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuit = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategoryLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnManufacturerLoad = new DevExpress.XtraBars.BarButtonItem();
            this.txtTime = new DevExpress.XtraBars.BarStaticItem();
            this.txtUser = new DevExpress.XtraBars.BarStaticItem();
            this.txtAuthen = new DevExpress.XtraBars.BarStaticItem();
            this.btnOrderLoad = new DevExpress.XtraBars.BarButtonItem();
            this.ViewPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.carPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.categoryPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.manuPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.orderPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AccountPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.businessPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.quickGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.linkCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.linkInsurance = new DevExpress.XtraNavBar.NavBarItem();
            this.linkPayment = new DevExpress.XtraNavBar.NavBarItem();
            this.linkReport = new DevExpress.XtraNavBar.NavBarItem();
            this.linkThisUser = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpBar = new DevExpress.XtraBars.BarSubItem();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.ribbonControl.BackColor = System.Drawing.Color.Aqua;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.ForeColor = System.Drawing.Color.Transparent;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnCarLoad,
            this.btnExit,
            this.btnLogin,
            this.btnStaffLoad,
            this.btnManagerLoad,
            this.barSubItem1,
            this.btnLogin1,
            this.btnLogout,
            this.btnQuit,
            this.btnCategoryLoad,
            this.btnManufacturerLoad,
            this.txtTime,
            this.txtUser,
            this.txtAuthen,
            this.btnOrderLoad,
            this.btnAccount});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(15, 19, 15, 19);
            this.ribbonControl.MaxItemId = 33;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ViewPage,
            this.AccountPage});
            this.ribbonControl.QuickToolbarItemLinks.Add(this.barSubItem1);
            this.ribbonControl.Size = new System.Drawing.Size(1144, 182);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ShowCustomizationMenu += new DevExpress.XtraBars.Ribbon.RibbonCustomizationMenuEventHandler(this.ribbonControl_ShowCustomizationMenu);
            // 
            // btnCarLoad
            // 
            this.btnCarLoad.Caption = "Car";
            this.btnCarLoad.DropDownEnabled = false;
            this.btnCarLoad.Id = 2;
            this.btnCarLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCarLoad.ImageOptions.SvgImage")));
            this.btnCarLoad.LargeWidth = 80;
            this.btnCarLoad.Name = "btnCarLoad";
            this.btnCarLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCarLoad_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 13;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Login";
            this.btnLogin.Id = 15;
            this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage")));
            this.btnLogin.Name = "btnLogin";
            // 
            // btnStaffLoad
            // 
            this.btnStaffLoad.Caption = "Staff";
            this.btnStaffLoad.Id = 16;
            this.btnStaffLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStaffLoad.ImageOptions.SvgImage")));
            this.btnStaffLoad.LargeWidth = 80;
            this.btnStaffLoad.Name = "btnStaffLoad";
            this.btnStaffLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaff_ItemClick);
            // 
            // btnManagerLoad
            // 
            this.btnManagerLoad.Caption = "Manager";
            this.btnManagerLoad.Id = 17;
            this.btnManagerLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnManagerLoad.ImageOptions.SvgImage")));
            this.btnManagerLoad.LargeWidth = 80;
            this.btnManagerLoad.Name = "btnManagerLoad";
            this.btnManagerLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnManager_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "User Bar";
            this.barSubItem1.Hint = "User Bar";
            this.barSubItem1.Id = 19;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.ImageOptions.SvgImageSize = new System.Drawing.Size(500, 500);
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLogin1, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLogout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuit)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLogin1
            // 
            this.btnLogin1.Caption = "Login";
            this.btnLogin1.Id = 21;
            this.btnLogin1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin1.ImageOptions.SvgImage")));
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin1_ItemClick);
            // 
            // btnAccount
            // 
            this.btnAccount.Caption = "Account";
            this.btnAccount.Id = 32;
            this.btnAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.ImageOptions.Image")));
            this.btnAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.ImageOptions.LargeImage")));
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccount_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Logout";
            this.btnLogout.Id = 22;
            this.btnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogout.ImageOptions.SvgImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Caption = "Exit";
            this.btnQuit.Id = 23;
            this.btnQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.ImageOptions.Image")));
            this.btnQuit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.ImageOptions.LargeImage")));
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuit_ItemClick);
            // 
            // btnCategoryLoad
            // 
            this.btnCategoryLoad.Caption = "Category";
            this.btnCategoryLoad.Id = 24;
            this.btnCategoryLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCategoryLoad.ImageOptions.SvgImage")));
            this.btnCategoryLoad.LargeWidth = 80;
            this.btnCategoryLoad.Name = "btnCategoryLoad";
            this.btnCategoryLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategoryLoad_ItemClick);
            // 
            // btnManufacturerLoad
            // 
            this.btnManufacturerLoad.Caption = "Manufacturer";
            this.btnManufacturerLoad.Id = 25;
            this.btnManufacturerLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnManufacturerLoad.ImageOptions.SvgImage")));
            this.btnManufacturerLoad.LargeWidth = 80;
            this.btnManufacturerLoad.Name = "btnManufacturerLoad";
            this.btnManufacturerLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnManufacturer_ItemClick);
            // 
            // txtTime
            // 
            this.txtTime.Caption = "Date: ";
            this.txtTime.Id = 26;
            this.txtTime.Name = "txtTime";
            // 
            // txtUser
            // 
            this.txtUser.Caption = "User: ";
            this.txtUser.Id = 27;
            this.txtUser.Name = "txtUser";
            // 
            // txtAuthen
            // 
            this.txtAuthen.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtAuthen.Caption = "Status: ";
            this.txtAuthen.Id = 28;
            this.txtAuthen.Name = "txtAuthen";
            // 
            // btnOrderLoad
            // 
            this.btnOrderLoad.Caption = "Contract";
            this.btnOrderLoad.Id = 30;
            this.btnOrderLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderLoad.ImageOptions.Image")));
            this.btnOrderLoad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOrderLoad.ImageOptions.LargeImage")));
            this.btnOrderLoad.LargeWidth = 80;
            this.btnOrderLoad.Name = "btnOrderLoad";
            this.btnOrderLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOrderLoad_ItemClick);
            // 
            // ViewPage
            // 
            this.ViewPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.carPageGroup,
            this.categoryPageGroup,
            this.manuPageGroup,
            this.orderPageGroup});
            this.ViewPage.Name = "ViewPage";
            this.ViewPage.Text = "Business";
            // 
            // carPageGroup
            // 
            this.carPageGroup.AllowTextClipping = false;
            this.carPageGroup.ItemLinks.Add(this.btnCarLoad);
            this.carPageGroup.Name = "carPageGroup";
            // 
            // categoryPageGroup
            // 
            this.categoryPageGroup.ItemLinks.Add(this.btnCategoryLoad);
            this.categoryPageGroup.Name = "categoryPageGroup";
            // 
            // manuPageGroup
            // 
            this.manuPageGroup.ItemLinks.Add(this.btnManufacturerLoad);
            this.manuPageGroup.Name = "manuPageGroup";
            // 
            // orderPageGroup
            // 
            this.orderPageGroup.ItemLinks.Add(this.btnOrderLoad);
            this.orderPageGroup.Name = "orderPageGroup";
            // 
            // AccountPage
            // 
            this.AccountPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.businessPageGroup});
            this.AccountPage.Name = "AccountPage";
            this.AccountPage.Text = "User";
            // 
            // businessPageGroup
            // 
            this.businessPageGroup.ItemLinks.Add(this.btnStaffLoad);
            this.businessPageGroup.ItemLinks.Add(this.btnManagerLoad);
            this.businessPageGroup.Name = "businessPageGroup";
            this.businessPageGroup.Text = "Company";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.BackColor = System.Drawing.Color.Gray;
            this.ribbonStatusBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ribbonStatusBar.ItemLinks.Add(this.txtTime);
            this.ribbonStatusBar.ItemLinks.Add(this.txtUser);
            this.ribbonStatusBar.ItemLinks.Add(this.txtAuthen);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 765);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(15);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1144, 27);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.splitContainerControl1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 182);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.Color.White;
            this.splitContainerControl1.Panel2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel2.AutoScroll = true;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1144, 610);
            this.splitContainerControl1.SplitterPosition = 267;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.quickGroup;
            this.navBarControl.Appearance.Background.BackColor = System.Drawing.Color.Silver;
            this.navBarControl.Appearance.Background.BackColor2 = System.Drawing.Color.Silver;
            this.navBarControl.Appearance.Background.BorderColor = System.Drawing.Color.Silver;
            this.navBarControl.Appearance.Background.ForeColor = System.Drawing.Color.Silver;
            this.navBarControl.Appearance.Background.Options.UseBackColor = true;
            this.navBarControl.Appearance.Background.Options.UseBorderColor = true;
            this.navBarControl.Appearance.Background.Options.UseForeColor = true;
            this.navBarControl.Appearance.GroupBackground.BackColor = System.Drawing.Color.Silver;
            this.navBarControl.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.Silver;
            this.navBarControl.Appearance.GroupBackground.BorderColor = System.Drawing.Color.Silver;
            this.navBarControl.Appearance.GroupBackground.ForeColor = System.Drawing.Color.Silver;
            this.navBarControl.Appearance.GroupBackground.Options.UseBackColor = true;
            this.navBarControl.Appearance.GroupBackground.Options.UseBorderColor = true;
            this.navBarControl.Appearance.GroupBackground.Options.UseForeColor = true;
            this.navBarControl.BackColor = System.Drawing.Color.Silver;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.quickGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.linkCustomer,
            this.linkInsurance,
            this.linkPayment,
            this.linkThisUser,
            this.linkReport});
            this.navBarControl.LargeImages = this.navbarImageCollectionLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Margin = new System.Windows.Forms.Padding(15);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 267;
            this.navBarControl.Size = new System.Drawing.Size(267, 600);
            this.navBarControl.SmallImages = this.navbarImageCollection;
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
            // 
            // quickGroup
            // 
            this.quickGroup.Appearance.FontSizeDelta = 1;
            this.quickGroup.Appearance.Options.UseFont = true;
            this.quickGroup.AppearanceHotTracked.BackColor = System.Drawing.Color.Silver;
            this.quickGroup.AppearanceHotTracked.BackColor2 = System.Drawing.Color.Silver;
            this.quickGroup.AppearanceHotTracked.BorderColor = System.Drawing.Color.Silver;
            this.quickGroup.AppearanceHotTracked.ForeColor = System.Drawing.Color.Silver;
            this.quickGroup.AppearanceHotTracked.Options.UseBackColor = true;
            this.quickGroup.AppearanceHotTracked.Options.UseBorderColor = true;
            this.quickGroup.AppearanceHotTracked.Options.UseForeColor = true;
            this.quickGroup.Caption = "Quick menu";
            this.quickGroup.Expanded = true;
            this.quickGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.quickGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("quickGroup.ImageOptions.LargeImage")));
            this.quickGroup.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("quickGroup.ImageOptions.SmallImage")));
            this.quickGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkInsurance),
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkPayment),
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkReport)});
            this.quickGroup.Name = "quickGroup";
            // 
            // linkCustomer
            // 
            this.linkCustomer.Caption = "Customer";
            this.linkCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("linkCustomer.ImageOptions.LargeImage")));
            this.linkCustomer.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("linkCustomer.ImageOptions.SmallImage")));
            this.linkCustomer.Name = "linkCustomer";
            this.linkCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.LinkListCustomer_LinkClicked);
            // 
            // linkInsurance
            // 
            this.linkInsurance.Caption = "Insurance";
            this.linkInsurance.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("linkInsurance.ImageOptions.LargeImage")));
            this.linkInsurance.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("linkInsurance.ImageOptions.SmallImage")));
            this.linkInsurance.Name = "linkInsurance";
            this.linkInsurance.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.linkInsurance_LinkClicked);
            // 
            // linkPayment
            // 
            this.linkPayment.Caption = "Payment";
            this.linkPayment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("linkPayment.ImageOptions.LargeImage")));
            this.linkPayment.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("linkPayment.ImageOptions.SmallImage")));
            this.linkPayment.Name = "linkPayment";
            this.linkPayment.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.linkPayment_LinkClicked);
            // 
            // linkReport
            // 
            this.linkReport.Caption = "Statistic";
            this.linkReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("linkReport.ImageOptions.LargeImage")));
            this.linkReport.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("linkReport.ImageOptions.SmallImage")));
            this.linkReport.Name = "linkReport";
            this.linkReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.linkReport_LinkClicked);
            // 
            // linkThisUser
            // 
            this.linkThisUser.Caption = "Manager";
            this.linkThisUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("linkThisUser.ImageOptions.LargeImage")));
            this.linkThisUser.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("linkThisUser.ImageOptions.SmallImage")));
            this.linkThisUser.Name = "linkThisUser";
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Silver;
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            this.navbarImageCollection.TransparentColor = System.Drawing.Color.Silver;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // helpBar
            // 
            this.helpBar.Caption = "Help Bar";
            this.helpBar.Id = 11;
            this.helpBar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("helpBar.ImageOptions.Image")));
            this.helpBar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("helpBar.ImageOptions.LargeImage")));
            this.helpBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLogin),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
            this.helpBar.Name = "helpBar";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "ribbonPage6";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "ribbonPage7";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 792);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.LargeImage")));
            this.InactiveGlowColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "CarSale Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage AccountPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup businessPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ViewPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup carPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem btnCarLoad;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup quickGroup;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.XtraNavBar.NavBarItem linkCustomer;
        private DevExpress.XtraNavBar.NavBarItem linkInsurance;
        private DevExpress.XtraNavBar.NavBarItem linkPayment;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnStaffLoad;
        private DevExpress.XtraBars.BarButtonItem btnManagerLoad;
        private DevExpress.XtraBars.BarSubItem helpBar;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnLogin1;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnQuit;
        private DevExpress.XtraBars.BarButtonItem btnCategoryLoad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup categoryPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup manuPageGroup;
        private DevExpress.XtraBars.BarButtonItem btnManufacturerLoad;
        private DevExpress.XtraBars.BarStaticItem txtTime;
        private DevExpress.XtraBars.BarStaticItem txtUser;
        private DevExpress.XtraBars.BarStaticItem txtAuthen;
        private DevExpress.XtraBars.BarButtonItem btnOrderLoad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup orderPageGroup;
        private DevExpress.XtraNavBar.NavBarItem linkThisUser;
        private DevExpress.XtraNavBar.NavBarItem linkReport;
        private DevExpress.XtraBars.BarButtonItem btnAccount;
    }
}

