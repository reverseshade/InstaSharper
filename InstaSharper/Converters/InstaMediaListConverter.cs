﻿using System;
using System.Linq;
using InstaSharper.Classes.Models;
using InstaSharper.ResponseWrappers;

namespace InstaSharper.Converters
{
    internal class InstaMediaListConverter : IObjectConverter<InstaMediaList, InstaMediaListResponse>
    {
        public InstaMediaListResponse SourceObject { get; set; }

        public InstaMediaList Convert()
        {
            if (SourceObject == null) throw new ArgumentNullException($"Source object");
            var mediaList = new InstaMediaList();
            mediaList.AddRange(
                SourceObject.Medias.Select(ConvertersFabric.GetSingleMediaConverter)
                    .Select(converter => converter.Convert()));
            return mediaList;
        }
    }
}