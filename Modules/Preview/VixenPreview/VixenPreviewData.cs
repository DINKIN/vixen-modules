﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Drawing;
using Common.Controls.ColorManagement.ColorModels;
using Vixen.Module;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using VixenModules.Preview.VixenPreview.Shapes;
using Vixen.Execution.Context;
using Vixen.Module.Preview;
using Vixen.Data.Value;
using Vixen.Sys;

namespace VixenModules.Preview.VixenPreview
{
    [DataContract]
    public class VixenPreviewData : ModuleDataModelBase
    {
        private int _top, _left, _width, _height;
        private List<DisplayItem> _displayItems = new List<DisplayItem>();
        private string _backgroundFileName;
        private int _backgroundAlpha = 255;

        public VixenPreviewData()
        {
        }

        public override IModuleDataModel Clone()
        {
            Console.WriteLine("Clone");
            VixenPreviewData result = new VixenPreviewData
            {
                Width = 1024,
                Height = 800
            };
            return result;
        }

        [DataMember]
        public int BackgroundAlpha
        {
            get { return _backgroundAlpha; }
            set { _backgroundAlpha = value; }
        }

        [DataMember]
        public string BackgroundFileName
        {
            get { return _backgroundFileName; }
            set { _backgroundFileName = value; }
        }

        [DataMember]
        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }

        [DataMember]
        public int Left
        {
            get { return _left; }
            set { _left = value; }
        }

        [DataMember]
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        [DataMember]
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        [DataMember]
        public List<DisplayItem> DisplayItems
        {
            get
            {
                return _displayItems ?? (_displayItems = new List<DisplayItem>());
            }

            set
            {
                _displayItems = value ?? new List<DisplayItem>();
            }
        }

        //public List<PreviewBaseShape> DisplayItems
        //{
        //    get
        //    {
        //        if (_displayItems == null)
        //        {
        //            _displayItems = new List<PreviewBaseShape>();
        //            Console.WriteLine("_displayItems==null");
        //        }
        //        return _displayItems;
        //    }

        //    set
        //    {
        //        _displayItems = value;
        //        Console.WriteLine("_displayItems Set");
        //        //_displayItems = value ?? new List<PreviewBaseShape>();
        //        //PropertyChanged.NotifyPropertyChanged("DisplayItems", this);
        //    }
        //}

    }
}
