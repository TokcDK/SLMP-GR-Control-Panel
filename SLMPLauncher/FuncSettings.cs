using System.IO;

namespace SLMPLauncher
{
    public class FuncSettings
    {
        public static void setSettingsPreset(int value)
        {
            if (value == 0)
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "16");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iTexMipMapSkip", "2");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fLightLODStartFade", "200.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultActors", "3.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultObjects", "3.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultItems", "2.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iShadowMapResolution", "512");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Grass", "fGrassStartFadeDistance", "1000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Grass", "iMinGrassSize", "100");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel1FadeDist", "4096.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel2FadeDist", "3072.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fShadowDistance", "2000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fTreeLoadDistance", "12500.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockMaximumDistance", "75000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel1Distance", "25000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel0Distance", "15000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fSplitDistanceMult", "0.4000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fTreesMidLODSwitchDist", "3500.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "MAIN", "fSkyCellRefFadeDistance", "50000");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODLand", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODObjects", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODTrees", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectSky", "1");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bDecals", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bSkinnedDecals", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecals", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecalsPerActor", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxDecalsPerFrame", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxSkinDecalsPerFrame", "0");
            }
            else if (value == 1)
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "2");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "16");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iTexMipMapSkip", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fLightLODStartFade", "1000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultActors", "5.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultObjects", "6.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultItems", "5.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iShadowMapResolution", "1024");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Grass", "fGrassStartFadeDistance", "3000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Grass", "iMinGrassSize", "75");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel1FadeDist", "4096.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel2FadeDist", "3072.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fShadowDistance", "2500.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fTreeLoadDistance", "25000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockMaximumDistance", "100000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel1Distance", "32768.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel0Distance", "20480.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fSplitDistanceMult", "0.7500");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fTreesMidLODSwitchDist", "4000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "MAIN", "fSkyCellRefFadeDistance", "150000");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODLand", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODObjects", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODTrees", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectSky", "1");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bDecals", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bSkinnedDecals", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecals", "35");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecalsPerActor", "20");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxDecalsPerFrame", "20");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxSkinDecalsPerFrame", "20");
            }
            else if (value == 2)
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "4");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "16");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iTexMipMapSkip", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fLightLODStartFade", "2500.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultActors", "9.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultObjects", "10.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultItems", "7.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iShadowMapResolution", "2048");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Grass", "fGrassStartFadeDistance", "5000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Grass", "iMinGrassSize", "60");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel1FadeDist", "16896.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel2FadeDist", "16896.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fShadowDistance", "4000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fTreeLoadDistance", "40000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockMaximumDistance", "150000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel1Distance", "40000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel0Distance", "25000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fSplitDistanceMult", "1.1000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fTreesMidLODSwitchDist", "5000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "MAIN", "fSkyCellRefFadeDistance", "300000");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODLand", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODObjects", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODTrees", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectSky", "1");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bDecals", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bSkinnedDecals", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecals", "50");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecalsPerActor", "40");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxDecalsPerFrame", "50");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxSkinDecalsPerFrame", "50");
            }
            else if (value == 3)
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "8");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "16");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iTexMipMapSkip", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fLightLODStartFade", "3500.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultActors", "15.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultObjects", "15.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "LOD", "fLODFadeOutMultItems", "15.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iShadowMapResolution", "4096");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Grass", "fGrassStartFadeDistance", "7000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Grass", "iMinGrassSize", "50");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel1FadeDist", "16896.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fMeshLODLevel2FadeDist", "16896.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fShadowDistance", "8000.0000");

                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fTreeLoadDistance", "75000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockMaximumDistance", "250000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel1Distance", "70000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fBlockLevel0Distance", "35000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "TerrainManager", "fSplitDistanceMult", "1.5000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "fTreesMidLODSwitchDist", "10000000.0000");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "MAIN", "fSkyCellRefFadeDistance", "600000");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODLand", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODObjects", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectLODTrees", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Water", "bReflectSky", "1");

                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bDecals", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "bSkinnedDecals", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecals", "100");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Decals", "uMaxSkinDecalsPerActor", "60");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxDecalsPerFrame", "100");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxSkinDecalsPerFrame", "100");
            }
            FormMain.settingsPreset = value;
            checkENB(false);
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static void physicsFPS()
        {
            FuncParser.iniWrite(FormMain.pathSkyrimINI, "HAVOK", "fMaxTime", (((double)1 / FormMain.predictFPS).ToString() + "000000").Replace(",", ".").Remove(6));
            restoreENBLimit();
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static void restoreENBLimit()
        {
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "LIMITER", "FPSLimit", FormMain.predictFPS.ToString() + ".0");
            }
        }
        public static void restoreENBAdapter()
        {
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                int value = FuncParser.intRead(FormMain.pathSkyrimINI, "Display", "iAdapter");
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "MULTIHEAD", "VideoAdapterIndex", value.ToString());
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "MULTIHEAD", "ForceVideoAdapterIndex", (value > 0).ToString().ToLower());
            }
        }
        public static void restoreENBBorderless()
        {
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "WINDOW", "ForceBorderless", (FuncParser.stringRead(FormMain.pathSkyrimPrefsINI, "Display", "bFull Screen") == "0").ToString().ToLower());
            }
        }
        public static void restoreENBVSync()
        {
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "ENGINE", "EnableVSync", (FuncParser.stringRead(FormMain.pathSkyrimINI, "Display", "iPresentInterval") == "1").ToString().ToLower());
            }
        }
        public static void restoreENBVideoMemory()
        {
            if (File.Exists(FormENB.pathENBLocalINI))
            {
                FuncParser.iniWrite(FormENB.pathENBLocalINI, "MEMORY", "VideoMemorySizeMb", FuncParser.stringRead(FormMain.pathLauncherINI, "ENB", "MemorySizeMb"));
            }
        }
        public static bool checkENB(bool RemoveENB)
        {
            if (File.Exists(FormMain.pathGameFolder + @"d3d9.dll") && File.Exists(FormMain.pathGameFolder + "enblocal.ini"))
            {
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "0");
                FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFloatPointRenderTarget", "1");
                FuncParser.iniWrite(FormMain.pathSkyrimINI, "Display", "bAllowScreenshot", "0");
                return true;
            }
            else
            {
                if (RemoveENB)
                {
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMaxAnisotropy", "16");
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "iMultiSample", "2");
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFXAAEnabled", "1");
                }
                else
                {
                    FuncParser.iniWrite(FormMain.pathSkyrimPrefsINI, "Display", "bFloatPointRenderTarget", "0");
                    FuncParser.iniWrite(FormMain.pathSkyrimINI, "Display", "bAllowScreenshot", "1");
                }
                return false;
            }
        }
    }
}