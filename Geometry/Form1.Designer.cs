using System.Windows.Forms;

namespace Geometry
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenGL_Painter = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.NumericUpDownTranslateX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownTranslateY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownTranslateZ = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownRotateX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownRotateY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownRotateZ = new System.Windows.Forms.NumericUpDown();
            this.loadButton = new System.Windows.Forms.Button();
            this.NumericUpDownScaleX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownScaleY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownScaleZ = new System.Windows.Forms.NumericUpDown();
            this.ScaleLabel1 = new System.Windows.Forms.Label();
            this.NumericUpDownShearXY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownShearYX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownShearZX = new System.Windows.Forms.NumericUpDown();
            this.ScaleLabel2 = new System.Windows.Forms.Label();
            this.ScaleСheckBox = new System.Windows.Forms.CheckBox();
            this.OPPLabel1 = new System.Windows.Forms.Label();
            this.NumericUpDownOPPX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownOPPY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownOPPZ = new System.Windows.Forms.NumericUpDown();
            this.OPPCheckBox = new System.Windows.Forms.CheckBox();
            this.OPPLabel2 = new System.Windows.Forms.Label();
            this.NumericUpDownOPPXYZ = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownScaleXYZ = new System.Windows.Forms.NumericUpDown();
            this.TranslateGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonTranslateZ = new System.Windows.Forms.Button();
            this.ButtonTranslateY = new System.Windows.Forms.Button();
            this.ButtonTranslateX = new System.Windows.Forms.Button();
            this.ScaleGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonScaleZ = new System.Windows.Forms.Button();
            this.ButtonScaleY = new System.Windows.Forms.Button();
            this.ButtonScaleX = new System.Windows.Forms.Button();
            this.ButtonScaleXYZ = new System.Windows.Forms.Button();
            this.RotateGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonRotateZ = new System.Windows.Forms.Button();
            this.ButtonRotateY = new System.Windows.Forms.Button();
            this.ButtonRotateX = new System.Windows.Forms.Button();
            this.ShearGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumericUpDownShearZY = new System.Windows.Forms.NumericUpDown();
            this.ButtonShearZ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumericUpDownShearXZ = new System.Windows.Forms.NumericUpDown();
            this.ButtonShearX = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumericUpDownShearYZ = new System.Windows.Forms.NumericUpDown();
            this.ButtonShearY = new System.Windows.Forms.Button();
            this.OPPGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonOPPZ = new System.Windows.Forms.Button();
            this.ButtonOPPY = new System.Windows.Forms.Button();
            this.ButtonOPPX = new System.Windows.Forms.Button();
            this.ButtonOPPXYZ = new System.Windows.Forms.Button();
            this.CentreButton = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.CurveSurface = new System.Windows.Forms.Button();
            this.StartRotating = new System.Windows.Forms.Button();
            this.EndRotating = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTranslateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTranslateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTranslateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRotateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRotateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRotateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownScaleZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearYX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearZX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOPPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOPPY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOPPZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOPPXYZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownScaleXYZ)).BeginInit();
            this.TranslateGroupBox.SuspendLayout();
            this.ScaleGroupBox.SuspendLayout();
            this.RotateGroupBox.SuspendLayout();
            this.ShearGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearZY)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearXZ)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearYZ)).BeginInit();
            this.OPPGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenGL_Painter
            // 
            this.OpenGL_Painter.AccumBits = ((byte)(0));
            this.OpenGL_Painter.AutoCheckErrors = false;
            this.OpenGL_Painter.AutoFinish = false;
            this.OpenGL_Painter.AutoMakeCurrent = true;
            this.OpenGL_Painter.AutoSwapBuffers = true;
            this.OpenGL_Painter.BackColor = System.Drawing.Color.Black;
            this.OpenGL_Painter.ColorBits = ((byte)(32));
            this.OpenGL_Painter.DepthBits = ((byte)(16));
            this.OpenGL_Painter.Location = new System.Drawing.Point(0, 0);
            this.OpenGL_Painter.Name = "OpenGL_Painter";
            this.OpenGL_Painter.Size = new System.Drawing.Size(1000, 1000);
            this.OpenGL_Painter.StencilBits = ((byte)(0));
            this.OpenGL_Painter.TabIndex = 4;
            this.OpenGL_Painter.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenGL_Painter_Paint);
            // 
            // NumericUpDownTranslateX
            // 
            this.NumericUpDownTranslateX.DecimalPlaces = 1;
            this.NumericUpDownTranslateX.Enabled = false;
            this.NumericUpDownTranslateX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownTranslateX.Location = new System.Drawing.Point(10, 70);
            this.NumericUpDownTranslateX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownTranslateX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumericUpDownTranslateX.Name = "NumericUpDownTranslateX";
            this.NumericUpDownTranslateX.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownTranslateX.TabIndex = 9;
            // 
            // NumericUpDownTranslateY
            // 
            this.NumericUpDownTranslateY.DecimalPlaces = 1;
            this.NumericUpDownTranslateY.Enabled = false;
            this.NumericUpDownTranslateY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownTranslateY.Location = new System.Drawing.Point(160, 70);
            this.NumericUpDownTranslateY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownTranslateY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumericUpDownTranslateY.Name = "NumericUpDownTranslateY";
            this.NumericUpDownTranslateY.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownTranslateY.TabIndex = 10;
            // 
            // NumericUpDownTranslateZ
            // 
            this.NumericUpDownTranslateZ.DecimalPlaces = 1;
            this.NumericUpDownTranslateZ.Enabled = false;
            this.NumericUpDownTranslateZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownTranslateZ.Location = new System.Drawing.Point(310, 70);
            this.NumericUpDownTranslateZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownTranslateZ.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumericUpDownTranslateZ.Name = "NumericUpDownTranslateZ";
            this.NumericUpDownTranslateZ.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownTranslateZ.TabIndex = 11;
            // 
            // NumericUpDownRotateX
            // 
            this.NumericUpDownRotateX.DecimalPlaces = 1;
            this.NumericUpDownRotateX.Enabled = false;
            this.NumericUpDownRotateX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownRotateX.Location = new System.Drawing.Point(10, 70);
            this.NumericUpDownRotateX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NumericUpDownRotateX.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.NumericUpDownRotateX.Name = "NumericUpDownRotateX";
            this.NumericUpDownRotateX.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownRotateX.TabIndex = 12;
            // 
            // NumericUpDownRotateY
            // 
            this.NumericUpDownRotateY.DecimalPlaces = 1;
            this.NumericUpDownRotateY.Enabled = false;
            this.NumericUpDownRotateY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownRotateY.Location = new System.Drawing.Point(160, 70);
            this.NumericUpDownRotateY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NumericUpDownRotateY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.NumericUpDownRotateY.Name = "NumericUpDownRotateY";
            this.NumericUpDownRotateY.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownRotateY.TabIndex = 13;
            // 
            // NumericUpDownRotateZ
            // 
            this.NumericUpDownRotateZ.DecimalPlaces = 1;
            this.NumericUpDownRotateZ.Enabled = false;
            this.NumericUpDownRotateZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownRotateZ.Location = new System.Drawing.Point(310, 70);
            this.NumericUpDownRotateZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NumericUpDownRotateZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.NumericUpDownRotateZ.Name = "NumericUpDownRotateZ";
            this.NumericUpDownRotateZ.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownRotateZ.TabIndex = 14;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(1180, 929);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(140, 24);
            this.loadButton.TabIndex = 15;
            this.loadButton.Text = "Загрузить файл";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // NumericUpDownScaleX
            // 
            this.NumericUpDownScaleX.DecimalPlaces = 1;
            this.NumericUpDownScaleX.Enabled = false;
            this.NumericUpDownScaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownScaleX.Location = new System.Drawing.Point(10, 70);
            this.NumericUpDownScaleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownScaleX.Name = "NumericUpDownScaleX";
            this.NumericUpDownScaleX.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownScaleX.TabIndex = 16;
            this.NumericUpDownScaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownScaleY
            // 
            this.NumericUpDownScaleY.DecimalPlaces = 1;
            this.NumericUpDownScaleY.Enabled = false;
            this.NumericUpDownScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownScaleY.Location = new System.Drawing.Point(160, 70);
            this.NumericUpDownScaleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownScaleY.Name = "NumericUpDownScaleY";
            this.NumericUpDownScaleY.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownScaleY.TabIndex = 17;
            this.NumericUpDownScaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownScaleZ
            // 
            this.NumericUpDownScaleZ.DecimalPlaces = 1;
            this.NumericUpDownScaleZ.Enabled = false;
            this.NumericUpDownScaleZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownScaleZ.Location = new System.Drawing.Point(310, 70);
            this.NumericUpDownScaleZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownScaleZ.Name = "NumericUpDownScaleZ";
            this.NumericUpDownScaleZ.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownScaleZ.TabIndex = 18;
            this.NumericUpDownScaleZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ScaleLabel1
            // 
            this.ScaleLabel1.AutoSize = true;
            this.ScaleLabel1.Location = new System.Drawing.Point(10, 20);
            this.ScaleLabel1.Name = "ScaleLabel1";
            this.ScaleLabel1.Size = new System.Drawing.Size(148, 13);
            this.ScaleLabel1.TabIndex = 19;
            this.ScaleLabel1.Text = "Масштабирование по осям:";
            // 
            // NumericUpDownShearXY
            // 
            this.NumericUpDownShearXY.DecimalPlaces = 1;
            this.NumericUpDownShearXY.Enabled = false;
            this.NumericUpDownShearXY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownShearXY.Location = new System.Drawing.Point(0, 45);
            this.NumericUpDownShearXY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDownShearXY.Name = "NumericUpDownShearXY";
            this.NumericUpDownShearXY.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownShearXY.TabIndex = 21;
            // 
            // NumericUpDownShearYX
            // 
            this.NumericUpDownShearYX.DecimalPlaces = 1;
            this.NumericUpDownShearYX.Enabled = false;
            this.NumericUpDownShearYX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownShearYX.Location = new System.Drawing.Point(0, 45);
            this.NumericUpDownShearYX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDownShearYX.Name = "NumericUpDownShearYX";
            this.NumericUpDownShearYX.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownShearYX.TabIndex = 22;
            // 
            // NumericUpDownShearZX
            // 
            this.NumericUpDownShearZX.DecimalPlaces = 1;
            this.NumericUpDownShearZX.Enabled = false;
            this.NumericUpDownShearZX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownShearZX.Location = new System.Drawing.Point(0, 45);
            this.NumericUpDownShearZX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDownShearZX.Name = "NumericUpDownShearZX";
            this.NumericUpDownShearZX.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownShearZX.TabIndex = 23;
            // 
            // ScaleLabel2
            // 
            this.ScaleLabel2.AutoSize = true;
            this.ScaleLabel2.Location = new System.Drawing.Point(10, 20);
            this.ScaleLabel2.Name = "ScaleLabel2";
            this.ScaleLabel2.Size = new System.Drawing.Size(141, 13);
            this.ScaleLabel2.TabIndex = 24;
            this.ScaleLabel2.Text = "Общее масштабирование:";
            // 
            // ScaleСheckBox
            // 
            this.ScaleСheckBox.AutoSize = true;
            this.ScaleСheckBox.Location = new System.Drawing.Point(10, 100);
            this.ScaleСheckBox.Name = "ScaleСheckBox";
            this.ScaleСheckBox.Size = new System.Drawing.Size(157, 17);
            this.ScaleСheckBox.TabIndex = 25;
            this.ScaleСheckBox.Text = "Общее масштабирование";
            this.ScaleСheckBox.UseVisualStyleBackColor = true;
            this.ScaleСheckBox.CheckedChanged += new System.EventHandler(this.ScaleСheckBox_CheckedChanged);
            // 
            // OPPLabel1
            // 
            this.OPPLabel1.AutoSize = true;
            this.OPPLabel1.Location = new System.Drawing.Point(10, 20);
            this.OPPLabel1.Name = "OPPLabel1";
            this.OPPLabel1.Size = new System.Drawing.Size(236, 13);
            this.OPPLabel1.TabIndex = 26;
            this.OPPLabel1.Text = "Одноточечное проективное преобразование:";
            // 
            // NumericUpDownOPPX
            // 
            this.NumericUpDownOPPX.DecimalPlaces = 1;
            this.NumericUpDownOPPX.Enabled = false;
            this.NumericUpDownOPPX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownOPPX.Location = new System.Drawing.Point(10, 70);
            this.NumericUpDownOPPX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownOPPX.Name = "NumericUpDownOPPX";
            this.NumericUpDownOPPX.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownOPPX.TabIndex = 27;
            this.NumericUpDownOPPX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownOPPY
            // 
            this.NumericUpDownOPPY.DecimalPlaces = 1;
            this.NumericUpDownOPPY.Enabled = false;
            this.NumericUpDownOPPY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownOPPY.Location = new System.Drawing.Point(160, 70);
            this.NumericUpDownOPPY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownOPPY.Name = "NumericUpDownOPPY";
            this.NumericUpDownOPPY.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownOPPY.TabIndex = 28;
            this.NumericUpDownOPPY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownOPPZ
            // 
            this.NumericUpDownOPPZ.DecimalPlaces = 1;
            this.NumericUpDownOPPZ.Enabled = false;
            this.NumericUpDownOPPZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownOPPZ.Location = new System.Drawing.Point(310, 70);
            this.NumericUpDownOPPZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownOPPZ.Name = "NumericUpDownOPPZ";
            this.NumericUpDownOPPZ.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownOPPZ.TabIndex = 29;
            this.NumericUpDownOPPZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OPPCheckBox
            // 
            this.OPPCheckBox.AutoSize = true;
            this.OPPCheckBox.Location = new System.Drawing.Point(10, 100);
            this.OPPCheckBox.Name = "OPPCheckBox";
            this.OPPCheckBox.Size = new System.Drawing.Size(288, 17);
            this.OPPCheckBox.TabIndex = 30;
            this.OPPCheckBox.Text = "Общее одноточечное проективное преобразование";
            this.OPPCheckBox.UseVisualStyleBackColor = true;
            this.OPPCheckBox.CheckedChanged += new System.EventHandler(this.OPPCheckBox_CheckedChanged);
            // 
            // OPPLabel2
            // 
            this.OPPLabel2.AutoSize = true;
            this.OPPLabel2.Location = new System.Drawing.Point(10, 20);
            this.OPPLabel2.Name = "OPPLabel2";
            this.OPPLabel2.Size = new System.Drawing.Size(272, 13);
            this.OPPLabel2.TabIndex = 31;
            this.OPPLabel2.Text = "Общее одноточечное проективное преобразование:";
            this.OPPLabel2.Visible = false;
            // 
            // NumericUpDownOPPXYZ
            // 
            this.NumericUpDownOPPXYZ.DecimalPlaces = 1;
            this.NumericUpDownOPPXYZ.Enabled = false;
            this.NumericUpDownOPPXYZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownOPPXYZ.Location = new System.Drawing.Point(10, 70);
            this.NumericUpDownOPPXYZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownOPPXYZ.Name = "NumericUpDownOPPXYZ";
            this.NumericUpDownOPPXYZ.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownOPPXYZ.TabIndex = 32;
            this.NumericUpDownOPPXYZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownOPPXYZ.Visible = false;
            // 
            // NumericUpDownScaleXYZ
            // 
            this.NumericUpDownScaleXYZ.DecimalPlaces = 1;
            this.NumericUpDownScaleXYZ.Enabled = false;
            this.NumericUpDownScaleXYZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownScaleXYZ.Location = new System.Drawing.Point(10, 70);
            this.NumericUpDownScaleXYZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownScaleXYZ.Name = "NumericUpDownScaleXYZ";
            this.NumericUpDownScaleXYZ.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownScaleXYZ.TabIndex = 33;
            this.NumericUpDownScaleXYZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownScaleXYZ.Visible = false;
            // 
            // TranslateGroupBox
            // 
            this.TranslateGroupBox.Controls.Add(this.ButtonTranslateZ);
            this.TranslateGroupBox.Controls.Add(this.ButtonTranslateY);
            this.TranslateGroupBox.Controls.Add(this.ButtonTranslateX);
            this.TranslateGroupBox.Controls.Add(this.NumericUpDownTranslateX);
            this.TranslateGroupBox.Controls.Add(this.NumericUpDownTranslateY);
            this.TranslateGroupBox.Controls.Add(this.NumericUpDownTranslateZ);
            this.TranslateGroupBox.Location = new System.Drawing.Point(1020, 10);
            this.TranslateGroupBox.Name = "TranslateGroupBox";
            this.TranslateGroupBox.Size = new System.Drawing.Size(460, 120);
            this.TranslateGroupBox.TabIndex = 34;
            this.TranslateGroupBox.TabStop = false;
            this.TranslateGroupBox.Text = "Параллельный перенос:";
            // 
            // ButtonTranslateZ
            // 
            this.ButtonTranslateZ.Location = new System.Drawing.Point(310, 40);
            this.ButtonTranslateZ.Name = "ButtonTranslateZ";
            this.ButtonTranslateZ.Size = new System.Drawing.Size(140, 20);
            this.ButtonTranslateZ.TabIndex = 14;
            this.ButtonTranslateZ.Text = "Переместить по Oz на:";
            this.ButtonTranslateZ.UseVisualStyleBackColor = true;
            this.ButtonTranslateZ.Click += new System.EventHandler(this.ButtonTranslateZ_Click);
            // 
            // ButtonTranslateY
            // 
            this.ButtonTranslateY.Location = new System.Drawing.Point(160, 40);
            this.ButtonTranslateY.Name = "ButtonTranslateY";
            this.ButtonTranslateY.Size = new System.Drawing.Size(140, 20);
            this.ButtonTranslateY.TabIndex = 13;
            this.ButtonTranslateY.Text = "Переместить по Oy на:";
            this.ButtonTranslateY.UseVisualStyleBackColor = true;
            this.ButtonTranslateY.Click += new System.EventHandler(this.ButtonTranslateY_Click);
            // 
            // ButtonTranslateX
            // 
            this.ButtonTranslateX.Location = new System.Drawing.Point(10, 40);
            this.ButtonTranslateX.Name = "ButtonTranslateX";
            this.ButtonTranslateX.Size = new System.Drawing.Size(140, 20);
            this.ButtonTranslateX.TabIndex = 12;
            this.ButtonTranslateX.Text = "Переместить по Ox на:";
            this.ButtonTranslateX.UseVisualStyleBackColor = true;
            this.ButtonTranslateX.Click += new System.EventHandler(this.ButtonTranslateX_Click);
            // 
            // ScaleGroupBox
            // 
            this.ScaleGroupBox.Controls.Add(this.ButtonScaleZ);
            this.ScaleGroupBox.Controls.Add(this.ButtonScaleY);
            this.ScaleGroupBox.Controls.Add(this.ButtonScaleX);
            this.ScaleGroupBox.Controls.Add(this.NumericUpDownScaleX);
            this.ScaleGroupBox.Controls.Add(this.NumericUpDownScaleY);
            this.ScaleGroupBox.Controls.Add(this.ScaleСheckBox);
            this.ScaleGroupBox.Controls.Add(this.NumericUpDownScaleZ);
            this.ScaleGroupBox.Controls.Add(this.NumericUpDownScaleXYZ);
            this.ScaleGroupBox.Controls.Add(this.ButtonScaleXYZ);
            this.ScaleGroupBox.Controls.Add(this.ScaleLabel1);
            this.ScaleGroupBox.Controls.Add(this.ScaleLabel2);
            this.ScaleGroupBox.Location = new System.Drawing.Point(1020, 140);
            this.ScaleGroupBox.Name = "ScaleGroupBox";
            this.ScaleGroupBox.Size = new System.Drawing.Size(460, 120);
            this.ScaleGroupBox.TabIndex = 35;
            this.ScaleGroupBox.TabStop = false;
            this.ScaleGroupBox.Text = "Масштабирование:";
            // 
            // ButtonScaleZ
            // 
            this.ButtonScaleZ.Location = new System.Drawing.Point(310, 40);
            this.ButtonScaleZ.Name = "ButtonScaleZ";
            this.ButtonScaleZ.Size = new System.Drawing.Size(140, 20);
            this.ButtonScaleZ.TabIndex = 36;
            this.ButtonScaleZ.Text = "Увеличить по Oz в X раз:";
            this.ButtonScaleZ.UseVisualStyleBackColor = true;
            this.ButtonScaleZ.Click += new System.EventHandler(this.ButtonScaleZ_Click);
            // 
            // ButtonScaleY
            // 
            this.ButtonScaleY.Location = new System.Drawing.Point(160, 40);
            this.ButtonScaleY.Name = "ButtonScaleY";
            this.ButtonScaleY.Size = new System.Drawing.Size(140, 20);
            this.ButtonScaleY.TabIndex = 35;
            this.ButtonScaleY.Text = "Увеличить по Oy в X раз:";
            this.ButtonScaleY.UseVisualStyleBackColor = true;
            this.ButtonScaleY.Click += new System.EventHandler(this.ButtonScaleY_Click);
            // 
            // ButtonScaleX
            // 
            this.ButtonScaleX.Location = new System.Drawing.Point(10, 40);
            this.ButtonScaleX.Name = "ButtonScaleX";
            this.ButtonScaleX.Size = new System.Drawing.Size(140, 20);
            this.ButtonScaleX.TabIndex = 34;
            this.ButtonScaleX.Text = "Увеличить по Ox в X раз:";
            this.ButtonScaleX.UseVisualStyleBackColor = true;
            this.ButtonScaleX.Click += new System.EventHandler(this.ButtonScaleX_Click);
            // 
            // ButtonScaleXYZ
            // 
            this.ButtonScaleXYZ.Location = new System.Drawing.Point(10, 40);
            this.ButtonScaleXYZ.Name = "ButtonScaleXYZ";
            this.ButtonScaleXYZ.Size = new System.Drawing.Size(140, 20);
            this.ButtonScaleXYZ.TabIndex = 37;
            this.ButtonScaleXYZ.Text = "Увеличить по XYZ на:";
            this.ButtonScaleXYZ.UseVisualStyleBackColor = true;
            this.ButtonScaleXYZ.Click += new System.EventHandler(this.ButtonScaleXYZ_Click);
            // 
            // RotateGroupBox
            // 
            this.RotateGroupBox.Controls.Add(this.ButtonRotateZ);
            this.RotateGroupBox.Controls.Add(this.ButtonRotateY);
            this.RotateGroupBox.Controls.Add(this.ButtonRotateX);
            this.RotateGroupBox.Controls.Add(this.NumericUpDownRotateX);
            this.RotateGroupBox.Controls.Add(this.NumericUpDownRotateY);
            this.RotateGroupBox.Controls.Add(this.NumericUpDownRotateZ);
            this.RotateGroupBox.Location = new System.Drawing.Point(1020, 270);
            this.RotateGroupBox.Name = "RotateGroupBox";
            this.RotateGroupBox.Size = new System.Drawing.Size(460, 120);
            this.RotateGroupBox.TabIndex = 36;
            this.RotateGroupBox.TabStop = false;
            this.RotateGroupBox.Text = "Поворот вокруг осей (В градусах):";
            // 
            // ButtonRotateZ
            // 
            this.ButtonRotateZ.Location = new System.Drawing.Point(310, 40);
            this.ButtonRotateZ.Name = "ButtonRotateZ";
            this.ButtonRotateZ.Size = new System.Drawing.Size(140, 20);
            this.ButtonRotateZ.TabIndex = 17;
            this.ButtonRotateZ.Text = "Повернуть вокруг Oz на:";
            this.ButtonRotateZ.UseVisualStyleBackColor = true;
            this.ButtonRotateZ.Click += new System.EventHandler(this.ButtonRotateZ_Click);
            // 
            // ButtonRotateY
            // 
            this.ButtonRotateY.Location = new System.Drawing.Point(160, 40);
            this.ButtonRotateY.Name = "ButtonRotateY";
            this.ButtonRotateY.Size = new System.Drawing.Size(140, 20);
            this.ButtonRotateY.TabIndex = 16;
            this.ButtonRotateY.Text = "Повернуть вокруг Oy на:";
            this.ButtonRotateY.UseVisualStyleBackColor = true;
            this.ButtonRotateY.Click += new System.EventHandler(this.ButtonRotateY_Click);
            // 
            // ButtonRotateX
            // 
            this.ButtonRotateX.Location = new System.Drawing.Point(10, 40);
            this.ButtonRotateX.Name = "ButtonRotateX";
            this.ButtonRotateX.Size = new System.Drawing.Size(140, 20);
            this.ButtonRotateX.TabIndex = 15;
            this.ButtonRotateX.Text = "Повернуть вокруг Ox на:";
            this.ButtonRotateX.UseVisualStyleBackColor = true;
            this.ButtonRotateX.Click += new System.EventHandler(this.ButtonRotateX_Click);
            // 
            // ShearGroupBox
            // 
            this.ShearGroupBox.Controls.Add(this.groupBox3);
            this.ShearGroupBox.Controls.Add(this.groupBox1);
            this.ShearGroupBox.Controls.Add(this.groupBox2);
            this.ShearGroupBox.Location = new System.Drawing.Point(1020, 400);
            this.ShearGroupBox.Name = "ShearGroupBox";
            this.ShearGroupBox.Size = new System.Drawing.Size(460, 120);
            this.ShearGroupBox.TabIndex = 37;
            this.ShearGroupBox.TabStop = false;
            this.ShearGroupBox.Text = "Косой сдвиг относительно осей:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NumericUpDownShearZY);
            this.groupBox3.Controls.Add(this.ButtonShearZ);
            this.groupBox3.Controls.Add(this.NumericUpDownShearZX);
            this.groupBox3.Location = new System.Drawing.Point(310, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 100);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Скос по xOy";
            // 
            // NumericUpDownShearZY
            // 
            this.NumericUpDownShearZY.DecimalPlaces = 1;
            this.NumericUpDownShearZY.Enabled = false;
            this.NumericUpDownShearZY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownShearZY.Location = new System.Drawing.Point(0, 70);
            this.NumericUpDownShearZY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDownShearZY.Name = "NumericUpDownShearZY";
            this.NumericUpDownShearZY.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownShearZY.TabIndex = 27;
            // 
            // ButtonShearZ
            // 
            this.ButtonShearZ.Location = new System.Drawing.Point(0, 20);
            this.ButtonShearZ.Name = "ButtonShearZ";
            this.ButtonShearZ.Size = new System.Drawing.Size(140, 20);
            this.ButtonShearZ.TabIndex = 26;
            this.ButtonShearZ.Text = "Скосить по оси Z на:";
            this.ButtonShearZ.UseVisualStyleBackColor = true;
            this.ButtonShearZ.Click += new System.EventHandler(this.ButtonShearZ_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumericUpDownShearXZ);
            this.groupBox1.Controls.Add(this.ButtonShearX);
            this.groupBox1.Controls.Add(this.NumericUpDownShearXY);
            this.groupBox1.Location = new System.Drawing.Point(10, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 100);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Скос по yOz";
            // 
            // NumericUpDownShearXZ
            // 
            this.NumericUpDownShearXZ.DecimalPlaces = 1;
            this.NumericUpDownShearXZ.Enabled = false;
            this.NumericUpDownShearXZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownShearXZ.Location = new System.Drawing.Point(0, 70);
            this.NumericUpDownShearXZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDownShearXZ.Name = "NumericUpDownShearXZ";
            this.NumericUpDownShearXZ.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownShearXZ.TabIndex = 25;
            // 
            // ButtonShearX
            // 
            this.ButtonShearX.Location = new System.Drawing.Point(0, 20);
            this.ButtonShearX.Name = "ButtonShearX";
            this.ButtonShearX.Size = new System.Drawing.Size(140, 20);
            this.ButtonShearX.TabIndex = 24;
            this.ButtonShearX.Text = "Скосить по оси X на:";
            this.ButtonShearX.UseVisualStyleBackColor = true;
            this.ButtonShearX.Click += new System.EventHandler(this.ButtonShearX_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumericUpDownShearYZ);
            this.groupBox2.Controls.Add(this.ButtonShearY);
            this.groupBox2.Controls.Add(this.NumericUpDownShearYX);
            this.groupBox2.Location = new System.Drawing.Point(160, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 100);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Скос по xOz";
            // 
            // NumericUpDownShearYZ
            // 
            this.NumericUpDownShearYZ.DecimalPlaces = 1;
            this.NumericUpDownShearYZ.Enabled = false;
            this.NumericUpDownShearYZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownShearYZ.Location = new System.Drawing.Point(0, 70);
            this.NumericUpDownShearYZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDownShearYZ.Name = "NumericUpDownShearYZ";
            this.NumericUpDownShearYZ.Size = new System.Drawing.Size(140, 20);
            this.NumericUpDownShearYZ.TabIndex = 26;
            // 
            // ButtonShearY
            // 
            this.ButtonShearY.Location = new System.Drawing.Point(0, 20);
            this.ButtonShearY.Name = "ButtonShearY";
            this.ButtonShearY.Size = new System.Drawing.Size(140, 20);
            this.ButtonShearY.TabIndex = 25;
            this.ButtonShearY.Text = "Скосить по оси Y на:";
            this.ButtonShearY.UseVisualStyleBackColor = true;
            this.ButtonShearY.Click += new System.EventHandler(this.ButtonShearY_Click);
            // 
            // OPPGroupBox
            // 
            this.OPPGroupBox.Controls.Add(this.ButtonOPPZ);
            this.OPPGroupBox.Controls.Add(this.ButtonOPPY);
            this.OPPGroupBox.Controls.Add(this.ButtonOPPX);
            this.OPPGroupBox.Controls.Add(this.OPPLabel1);
            this.OPPGroupBox.Controls.Add(this.OPPCheckBox);
            this.OPPGroupBox.Controls.Add(this.NumericUpDownOPPX);
            this.OPPGroupBox.Controls.Add(this.NumericUpDownOPPY);
            this.OPPGroupBox.Controls.Add(this.NumericUpDownOPPZ);
            this.OPPGroupBox.Controls.Add(this.NumericUpDownOPPXYZ);
            this.OPPGroupBox.Controls.Add(this.OPPLabel2);
            this.OPPGroupBox.Controls.Add(this.ButtonOPPXYZ);
            this.OPPGroupBox.Location = new System.Drawing.Point(1020, 530);
            this.OPPGroupBox.Name = "OPPGroupBox";
            this.OPPGroupBox.Size = new System.Drawing.Size(460, 120);
            this.OPPGroupBox.TabIndex = 38;
            this.OPPGroupBox.TabStop = false;
            this.OPPGroupBox.Text = " Одноточечное проективное преобразование:";
            // 
            // ButtonOPPZ
            // 
            this.ButtonOPPZ.Location = new System.Drawing.Point(310, 40);
            this.ButtonOPPZ.Name = "ButtonOPPZ";
            this.ButtonOPPZ.Size = new System.Drawing.Size(140, 20);
            this.ButtonOPPZ.TabIndex = 35;
            this.ButtonOPPZ.Text = "Применить фокус на Oz:";
            this.ButtonOPPZ.UseVisualStyleBackColor = true;
            this.ButtonOPPZ.Click += new System.EventHandler(this.ButtonOPPZ_Click);
            // 
            // ButtonOPPY
            // 
            this.ButtonOPPY.Location = new System.Drawing.Point(160, 40);
            this.ButtonOPPY.Name = "ButtonOPPY";
            this.ButtonOPPY.Size = new System.Drawing.Size(140, 20);
            this.ButtonOPPY.TabIndex = 34;
            this.ButtonOPPY.Text = "Применить фокус на Oy:";
            this.ButtonOPPY.UseVisualStyleBackColor = true;
            this.ButtonOPPY.Click += new System.EventHandler(this.ButtonOPPY_Click);
            // 
            // ButtonOPPX
            // 
            this.ButtonOPPX.Location = new System.Drawing.Point(10, 40);
            this.ButtonOPPX.Name = "ButtonOPPX";
            this.ButtonOPPX.Size = new System.Drawing.Size(140, 20);
            this.ButtonOPPX.TabIndex = 33;
            this.ButtonOPPX.Text = "Применить фокус на Ox:";
            this.ButtonOPPX.UseVisualStyleBackColor = true;
            this.ButtonOPPX.Click += new System.EventHandler(this.ButtonOPPX_Click);
            // 
            // ButtonOPPXYZ
            // 
            this.ButtonOPPXYZ.Location = new System.Drawing.Point(10, 40);
            this.ButtonOPPXYZ.Name = "ButtonOPPXYZ";
            this.ButtonOPPXYZ.Size = new System.Drawing.Size(140, 20);
            this.ButtonOPPXYZ.TabIndex = 36;
            this.ButtonOPPXYZ.Text = "Применить фокус на XYZ:";
            this.ButtonOPPXYZ.UseVisualStyleBackColor = true;
            this.ButtonOPPXYZ.Click += new System.EventHandler(this.ButtonOPPXYZ_Click);
            // 
            // CentreButton
            // 
            this.CentreButton.Enabled = false;
            this.CentreButton.Location = new System.Drawing.Point(1180, 668);
            this.CentreButton.Margin = new System.Windows.Forms.Padding(2);
            this.CentreButton.Name = "CentreButton";
            this.CentreButton.Size = new System.Drawing.Size(140, 20);
            this.CentreButton.TabIndex = 39;
            this.CentreButton.Text = "Вписать объект";
            this.CentreButton.UseVisualStyleBackColor = true;
            this.CentreButton.Click += new System.EventHandler(this.CentreButton_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(1180, 969);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(140, 20);
            this.ButtonExit.TabIndex = 41;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // CurveSurface
            // 
            this.CurveSurface.Location = new System.Drawing.Point(1180, 715);
            this.CurveSurface.Name = "CurveSurface";
            this.CurveSurface.Size = new System.Drawing.Size(140, 60);
            this.CurveSurface.TabIndex = 42;
            this.CurveSurface.Text = "Повернуть на КРИВУЮ на 90 градусов и нарисовать кусок поверхности";
            this.CurveSurface.UseVisualStyleBackColor = true;
            this.CurveSurface.Click += new System.EventHandler(this.CurveSurface_Click);
            // 
            // StartRotating
            // 
            this.StartRotating.Location = new System.Drawing.Point(1180, 785);
            this.StartRotating.Name = "StartRotating";
            this.StartRotating.Size = new System.Drawing.Size(140, 50);
            this.StartRotating.TabIndex = 43;
            this.StartRotating.Text = "Начать поворачивать объект с отражением от стенок";
            this.StartRotating.UseVisualStyleBackColor = true;
            this.StartRotating.Click += new System.EventHandler(this.StartRotating_Click);
            // 
            // EndRotating
            // 
            this.EndRotating.Location = new System.Drawing.Point(1180, 845);
            this.EndRotating.Name = "EndRotating";
            this.EndRotating.Size = new System.Drawing.Size(140, 50);
            this.EndRotating.TabIndex = 44;
            this.EndRotating.Text = "Закончить поворачивать объект с отражением от стенок";
            this.EndRotating.UseVisualStyleBackColor = true;
            this.EndRotating.Click += new System.EventHandler(this.EndRotating_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1066, 796);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 1001);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EndRotating);
            this.Controls.Add(this.StartRotating);
            this.Controls.Add(this.CurveSurface);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.CentreButton);
            this.Controls.Add(this.OPPGroupBox);
            this.Controls.Add(this.ShearGroupBox);
            this.Controls.Add(this.RotateGroupBox);
            this.Controls.Add(this.ScaleGroupBox);
            this.Controls.Add(this.TranslateGroupBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.OpenGL_Painter);
            this.Location = new System.Drawing.Point(10, 20);
            this.MinimumSize = new System.Drawing.Size(1500, 1040);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTranslateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTranslateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTranslateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRotateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRotateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRotateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownScaleZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearYX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearZX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOPPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOPPY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOPPZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOPPXYZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownScaleXYZ)).EndInit();
            this.TranslateGroupBox.ResumeLayout(false);
            this.ScaleGroupBox.ResumeLayout(false);
            this.ScaleGroupBox.PerformLayout();
            this.RotateGroupBox.ResumeLayout(false);
            this.ShearGroupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearZY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearXZ)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownShearYZ)).EndInit();
            this.OPPGroupBox.ResumeLayout(false);
            this.OPPGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGL_Painter;
        private NumericUpDown NumericUpDownTranslateX;
        private NumericUpDown NumericUpDownTranslateY;
        private NumericUpDown NumericUpDownTranslateZ;
        private NumericUpDown NumericUpDownRotateX;
        private NumericUpDown NumericUpDownRotateY;
        private NumericUpDown NumericUpDownRotateZ;
        private Button loadButton;
        private NumericUpDown NumericUpDownScaleX;
        private NumericUpDown NumericUpDownScaleY;
        private NumericUpDown NumericUpDownScaleZ;
        private Label ScaleLabel1;
        private NumericUpDown NumericUpDownShearXY;
        private NumericUpDown NumericUpDownShearYX;
        private NumericUpDown NumericUpDownShearZX;
        private Label ScaleLabel2;
        private CheckBox ScaleСheckBox;
        private Label OPPLabel1;
        private NumericUpDown NumericUpDownOPPX;
        private NumericUpDown NumericUpDownOPPY;
        private NumericUpDown NumericUpDownOPPZ;
        private CheckBox OPPCheckBox;
        private Label OPPLabel2;
        private NumericUpDown NumericUpDownOPPXYZ;
        private NumericUpDown NumericUpDownScaleXYZ;
        private GroupBox TranslateGroupBox;
        private GroupBox ScaleGroupBox;
        private GroupBox RotateGroupBox;
        private GroupBox ShearGroupBox;
        private GroupBox OPPGroupBox;
        private Button ButtonTranslateZ;
        private Button ButtonTranslateY;
        private Button ButtonTranslateX;
        private Button ButtonScaleXYZ;
        private Button ButtonScaleZ;
        private Button ButtonScaleY;
        private Button ButtonScaleX;
        private Button ButtonRotateZ;
        private Button ButtonRotateY;
        private Button ButtonRotateX;
        private Button ButtonShearZ;
        private Button ButtonShearY;
        private Button ButtonShearX;
        private Button ButtonOPPZ;
        private Button ButtonOPPY;
        private Button ButtonOPPX;
        private Button ButtonOPPXYZ;
        private GroupBox groupBox3;
        private NumericUpDown NumericUpDownShearZY;
        private GroupBox groupBox1;
        private NumericUpDown NumericUpDownShearXZ;
        private GroupBox groupBox2;
        private NumericUpDown NumericUpDownShearYZ;
        private Button CentreButton;
        private Button ButtonExit;
        private Button CurveSurface;
        private Button StartRotating;
        private Button EndRotating;
        private Button button1;
    }
}

