namespace Jgrass.FiddlerPlugin
{
    partial class FiddlerWPFHost
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wpfElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // wpfElementHost
            // 
            this.wpfElementHost.Location = new System.Drawing.Point(3, 3);
            this.wpfElementHost.Name = "wpfElementHost";
            this.wpfElementHost.Size = new System.Drawing.Size(144, 144);
            this.wpfElementHost.TabIndex = 0;
            this.wpfElementHost.Text = "WpfElementHost";
            this.wpfElementHost.Child = null;
            // 
            // FiddlerWPFHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wpfElementHost);
            this.Name = "FiddlerWPFHost";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost wpfElementHost;
    }
}
