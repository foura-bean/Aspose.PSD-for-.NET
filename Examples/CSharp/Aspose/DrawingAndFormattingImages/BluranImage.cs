﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.PSD.FileFormats.Psd;
using Aspose.PSD.FileFormats.Tiff.Enums;
using Aspose.PSD.ImageFilters.FilterOptions;
using Aspose.PSD.ImageOptions;
using Aspose.PSD.Sources;

namespace Aspose.PSD.Examples.Aspose.DrawingAndFormattingImages
{
    class BluranImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            //ExStart:BluranImage

            String sourceFile = dataDir + @"sample.psd";
            string destName = dataDir + @"BlurAnImage_out.gif";

            // Load an existing image into an instance of RasterImage class
            using (var image = Image.Load(sourceFile))
            {
                // Convert the image into RasterImage, 
                //Pass Bounds[rectangle] of image and GaussianBlurFilterOptions instance to Filter method and Save the results
                RasterImage rasterImage = (RasterImage)image;

                rasterImage.Filter(rasterImage.Bounds, new GaussianBlurFilterOptions(15, 15));

                rasterImage.Save(destName, new GifOptions());
            }
            //ExEnd:BluranImage

        }

    }
}