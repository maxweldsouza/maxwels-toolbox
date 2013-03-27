using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace MaxwelsToolbox07
{
    public partial class ThisAddIn
    {
        PowerPoint.ShapeRange clipboard;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void Copy()
        {
            if (this.Application.ActiveWindow.Selection.Type == PowerPoint.PpSelectionType.ppSelectionShapes)
            {
                clipboard = this.Application.ActiveWindow.Selection.ShapeRange;
            }
        }

        public void Paste(bool crop, bool position, bool rotation, bool width, bool height)
        {
            if (this.Application.ActiveWindow.Selection.Type == PowerPoint.PpSelectionType.ppSelectionShapes)
            {
                var pic = this.Application.ActiveWindow.Selection.ShapeRange;

                if (pic.Type == Office.MsoShapeType.msoPicture && crop)
                {
                    pic.PictureFormat.CropLeft = clipboard.PictureFormat.CropLeft;
                    pic.PictureFormat.CropRight = clipboard.PictureFormat.CropRight;
                    pic.PictureFormat.CropTop = clipboard.PictureFormat.CropTop;
                    pic.PictureFormat.CropBottom = clipboard.PictureFormat.CropBottom;
                }
                if (width && height)
                {
                    pic.LockAspectRatio = Office.MsoTriState.msoFalse;
                    pic.Width = clipboard.Width;
                    pic.Height = clipboard.Height;
                    pic.LockAspectRatio = clipboard.LockAspectRatio;
                }
                else
                {
                    if (width)
                    {
                        pic.Width = clipboard.Width;
                    }
                    if (height)
                    {
                        pic.Height = clipboard.Height;
                    }
                }

                if (position)
                {
                    pic.Top = clipboard.Top;
                    pic.Left = clipboard.Left;
                }

                if (rotation)
                    pic.Rotation = clipboard.Rotation;
            }
        }

        public void Reset()
        {

            this.Application.ActiveWindow.Selection.ShapeRange.PictureFormat.CropLeft = 0;
            this.Application.ActiveWindow.Selection.ShapeRange.PictureFormat.CropRight = 0;
            this.Application.ActiveWindow.Selection.ShapeRange.PictureFormat.CropTop = 0;
            this.Application.ActiveWindow.Selection.ShapeRange.PictureFormat.CropBottom = 0;
            this.Application.ActiveWindow.Selection.ShapeRange.ScaleHeight(1, Office.MsoTriState.msoCTrue);
            this.Application.ActiveWindow.Selection.ShapeRange.ScaleWidth(1, Office.MsoTriState.msoCTrue);
            this.Application.ActiveWindow.Selection.ShapeRange.Rotation = 0;
            //this.Application.ActiveWindow.Selection.ShapeRange.SetShapesDefaultProperties();
        }

        internal void ShowProps()
        {
            var shape = this.Application.ActiveWindow.Selection.ShapeRange;
            string message = String.Format("CropLeft = {0}\nCropRight = {1}\nCropTop = {2}\nCropBottom = {3}\nWidth = {4}\nHeight = {5}\nLeft = {6}\nTop = {7}",
              shape.PictureFormat.CropLeft.ToString(),
              shape.PictureFormat.CropRight.ToString(),
              shape.PictureFormat.CropTop.ToString(),
              shape.PictureFormat.CropBottom.ToString(),
              shape.Width,
              shape.Height,
              shape.Left,
              shape.Top);
            MessageBox.Show(message);
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
