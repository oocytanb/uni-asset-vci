﻿using System;
using UnityEngine;


namespace VCIGLTF
{
    public static class gltfImporter
    {
        [Obsolete("Use ImporterContext.Load(path)")]
        public static ImporterContext Load(string path)
        {
            var context = new ImporterContext();
            context.Load(path);
            context.ShowMeshes();
            context.EnableUpdateWhenOffscreen();
            return context;
        }

        [Obsolete("Use ImporterContext.Parse(path, bytes)")]
        public static ImporterContext Parse(string path, Byte[] bytes)
        {
            var context = new ImporterContext();
            context.Load(path);
            context.ShowMeshes();
            context.EnableUpdateWhenOffscreen();
            return context;
        }

        [Obsolete("use ImporterContext.Load()")]
        public static void Load(ImporterContext context)
        {
            context.Load();
            context.ShowMeshes();
            context.EnableUpdateWhenOffscreen();
        }
    }
}
