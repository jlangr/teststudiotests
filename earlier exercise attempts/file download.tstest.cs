using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using System.IO;

namespace jefftest
{

    public class file_download : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Verify Download Size")]
        public void VerifyDownloadSize()
        {
            Log.WriteLine("testing file length");
            var filename = (string)GetExtractedValue("DownloadFilename");
            Log.WriteLine("Download filename:" + filename);
                //  @"c:\Users\IEUser\Downloads\small-file.csv";
            
            var fileLength = new FileInfo(filename).Length;
            Log.WriteLine("file " + filename + " Length: " + fileLength);
            
         //   Assert.AreEqual(100, fileLength);
            Assert.IsTrue(fileLength > 100);
        }
    
        [CodedStep(@"Set Download Filename")]
        public void SpecifyDownloadFilename()
        {
            SetExtractedValue("DownloadFilename", @"c:\Users\IEUser\Downloads\small-file.csv");
            var message = "extracted value: " + GetExtractedValue("DownloadFilename");
            Log.WriteLine(message);
        }
    
        [CodedStep(@"New Coded Step")]
        public void file_download_CodedStep()
        {
            Log.WriteLine("VAR" + GetExtractedValue("DownloadFilename"));
        }
    }
}
