﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SLMPLauncher
{
    public static class FuncClear
    {
        static List<string> CustomIgnoreList = new List<string>();
        static List<string> IgnoreFilesList = new List<string> { @"atimgpud.dll", @"binkw32.dll", @"d3d9.dll", @"data\additemmenu2.bsa", @"data\additemmenu2.esp", @"data\acquisitivesoulgem.bsa", @"data\acquisitivesoulgem.esp", @"data\ahzmorehud.bsa", @"data\ahzmorehud.esp", @"data\alternatestart.bsa", @"data\alternatestart.esp", @"data\alwayspickupbooks.bsa", @"data\alwayspickupbooks.esp", @"data\amatteroftime.bsa", @"data\amatteroftime.esp", @"data\armorweapon.bsa", @"data\armorweapon.esp", @"data\audiooverhaulskyrim.bsa", @"data\audiooverhaulskyrim.esp", @"data\bfseffects.bsa", @"data\bfseffects.esp", @"data\blacksmith chests.bsa", @"data\blacksmith chests.esp", @"data\book covers skyrim.bsa", @"data\book covers skyrim.esp", @"data\camerascripter.bsa", @"data\camerascripter.esp", @"data\campfire.bsa", @"data\campfire.esm", @"data\ccfwaf.bsa", @"data\ccfwaf.esp", @"data\climatesoftamriel.bsa", @"data\climatesoftamriel.esp", @"data\coinpurse.bsa", @"data\coinpurse.esp", @"data\customizable camera.bsa", @"data\customizable camera.esp", @"data\cutting room floor.bsa", @"data\cutting room floor.esp", @"data\dawnguard.esm", @"data\deadlyspellimpacts.bsa", @"data\deadlyspellimpacts.esp", @"data\destructiblebottles.bsa", @"data\destructiblebottles.esp", @"data\disablefasttravel.bsa", @"data\disablefasttravel.esp", @"data\dragonborn.esm", @"data\dual sheath redux patch.esp", @"data\dual sheath redux.bsa", @"data\dual sheath redux.esp", @"data\dual wield parrying.bsa", @"data\dual wield parrying.esp", @"data\enb vision.bsa", @"data\enb vision.esp", @"data\enhanced blood.bsa", @"data\enhanced blood.esp", @"data\enhancedlightsfx.bsa", @"data\enhancedlightsfx.esp", @"data\eyeshairs.bsa", @"data\eyeshairs.esp", @"data\falskaar.bsa", @"data\falskaar.esp", @"data\florarespawnfix.bsa", @"data\florarespawnfix.esp", @"data\fnis.bsa", @"data\fnis.esp", @"data\follower commentary.bsa", @"data\follower commentary.esp", @"data\followeroutfits.bsa", @"data\followeroutfits.esp", @"data\footprints.bsa", @"data\footprints.esp", @"data\frostfall-ws.bsa", @"data\frostfall-ws.esp", @"data\frostfall.bsa", @"data\frostfall.esp", @"data\gamecomm.bsa", @"data\gamemesh1.bsa", @"data\gamemesh2.bsa", @"data\gamemesh3.bsa", @"data\gametext1.bsa", @"data\gametext2.bsa", @"data\gametext3.bsa", @"data\gametext4.bsa", @"data\gametext5.bsa", @"data\gametext6.bsa", @"data\gametext7.bsa", @"data\gametext8.bsa", @"data\gamevoice1.bsa", @"data\gamevoice2.bsa", @"data\getsnowy.bsa", @"data\getsnowy.esp", @"data\headtracking.bsa", @"data\headtracking.esp", @"data\hearthfires.esm", @"data\helmettoggle.bsa", @"data\helmettoggle.esp", @"data\horsearmor.bsa", @"data\horsearmor.esp", @"data\ihud.bsa", @"data\ihud.esp", @"data\immersive citizens.bsa", @"data\immersive citizens.esp", @"data\ineed - dd.esp", @"data\ineed.bsa", @"data\ineed.esp", @"data\interiors furniture fix.bsa", @"data\interiors furniture fix.esp", @"data\inviseyefixes.bsa", @"data\inviseyefixes.esp", @"data\jaxonzmapmarkers.bsa", @"data\jaxonzmapmarkers.esp", @"data\landscape improved.bsa", @"data\landscape improved.esp", @"data\leveled enemy.bsa", @"data\leveled enemy.esp", @"data\meshes\actors\character\character assets female\skeleton_female.hkx", @"data\meshes\actors\character\character assets\skeleton.hkx", @"data\meshes\actors\character\characters female\defaultfemale.hkx", @"data\meshes\actors\character\characters\defaultmale.hkx", @"data\meshes\animationdatasinglefile.txt", @"data\meshes\animationsetdatasinglefile.txt", @"data\ordinator.bsa", @"data\ordinator.esp", @"data\osa.bsa", @"data\osa.esm", @"data\quests markers.bsa", @"data\quests markers.esp", @"data\racemenu.bsa", @"data\racemenu.esp", @"data\scripts\fnis_aa2.pex", @"data\scripts\fnisversiongenerated.pex", @"data\skse\plugins\additemmenu2.dll", @"data\skse\plugins\additemmenu2.ini", @"data\skse\plugins\ahzmorehudplugin.dll", @"data\skse\plugins\armor_rating_rescaled.dll", @"data\skse\plugins\armor_rating_rescaled.ini", @"data\skse\plugins\barterfix.dll", @"data\skse\plugins\bugfixplugin.dll", @"data\skse\plugins\bugfixplugin.ini", @"data\skse\plugins\camerascripter.dll", @"data\skse\plugins\chargen.dll", @"data\skse\plugins\chargen.ini", @"data\skse\plugins\cpconvert.dll", @"data\skse\plugins\cpconvert.ini", @"data\skse\plugins\crashfixplugin.dll", @"data\skse\plugins\crashfixplugin.ini", @"data\skse\plugins\enchantreloadfix.dll", @"data\skse\plugins\encounter_zones_unlocked.dll", @"data\skse\plugins\encounter_zones_unlocked.ini", @"data\skse\plugins\hdtphysicsextensions.dll", @"data\skse\plugins\hdtphysicsextensions.ini", @"data\skse\plugins\hdtphysicsextensionsdefaultbbp.xml", @"data\skse\plugins\improvement_names.dll", @"data\skse\plugins\improvement_names.ini", @"data\skse\plugins\loadgamefix.dll", @"data\skse\plugins\memoryblockslog.dll", @"data\skse\plugins\memoryblockslog.ini", @"data\skse\plugins\mfgconsole.dll", @"data\skse\plugins\mfgconsole.ini", @"data\skse\plugins\nioverride.dll", @"data\skse\plugins\nioverride.ini", @"data\skse\plugins\osa.dll", @"data\skse\plugins\ru_fix.dll", @"data\skse\plugins\skse_enhancedcamera.dll", @"data\skse\plugins\skse_enhancedcamera.ini", @"data\skse\plugins\skse_russian_helper.dll", @"data\skse\plugins\skyrimsouls.dll", @"data\skse\plugins\skyrimsouls.ini", @"data\skse\plugins\storageutil.dll", @"data\skse\plugins\to_your_face.dll", @"data\skse\plugins\to_your_face.ini", @"data\skse\plugins\togglewalkrunfix.dll", @"data\skse\plugins\which_quests_item.dll", @"data\skse\plugins\which_quests_item.ini", @"data\skse\skse.ini", @"data\skyproc patchers\dual sheath redux patch\dual sheath redux patch.jar", @"data\skyrim.esm", @"data\skyui.bsa", @"data\skyui.esp", @"data\staticloadingscreens.bsa", @"data\staticloadingscreens.esp", @"data\tools\generatefnis_for_users\alternate_animationgroups.txt", @"data\tools\generatefnis_for_users\animevents.txt", @"data\tools\generatefnis_for_users\animvars.txt", @"data\tools\generatefnis_for_users\customprecachefiles.txt", @"data\tools\generatefnis_for_users\debugdata.txt", @"data\tools\generatefnis_for_users\dontaskagainforlink.txt", @"data\tools\generatefnis_for_users\fnismodlist.txt", @"data\tools\generatefnis_for_users\generatefnisforusers.exe", @"data\tools\generatefnis_for_users\hkxcmd.exe", @"data\tools\generatefnis_for_users\mypatches.txt", @"data\tools\generatefnis_for_users\patchlist.txt", @"data\tools\generatefnis_for_users\temporary_logs\.logs.txt", @"data\tradebarter.bsa", @"data\tradebarter.esp", @"data\unofficial skyrim legendary edition patch.bsa", @"data\unofficial skyrim legendary edition patch.esp", @"data\uiextensions.bsa", @"data\uiextensions.esp", @"data\update.bsa", @"data\update.esm", @"data\wearable lantern.bsa", @"data\wearable lantern.esp", @"data\womandress.bsa", @"data\womandress.esp", @"data\wondersofweather.bsa", @"data\wondersofweather.esp", @"data\wyrmstooth.bsa", @"data\wyrmstooth.esp", @"enbhost.exe", @"enblocal.ini", @"enbseries.ini", @"logs\.logs.txt", @"skse.exe", @"skse_1_9_32.dll", @"skse_loader.dll", @"skyrim.exe", @"skyrim\skyrim.ini", @"skyrim\skyrimprefs.ini", @"skyrim\slmpignorefiles.ini", @"skyrim\slmplauncher.exe", @"skyrim\slmplauncher.ini", @"skyrim\unrar.exe", @"steam_api.dll", @"tesv.exe" };
        static List<string> IgnoreFoldersList = new List<string> { @"_programs", @"data", @"data\camerascripts", @"data\meshes", @"data\meshes\0sa", @"data\meshes\0sp", @"data\meshes\actors", @"data\meshes\actors\character", @"data\meshes\actors\character\animations", @"data\meshes\actors\character\animations\0sex_0mf_d", @"data\meshes\actors\character\animations\0sex_0mf_k", @"data\meshes\actors\character\animations\0sex_0mf_m", @"data\meshes\actors\character\animations\0sex_0mf_s", @"data\meshes\actors\character\animations\0sex_0mf_u", @"data\meshes\actors\character\animations\0sex_emf_a", @"data\meshes\actors\character\animations\_esg_0er_f", @"data\meshes\actors\character\animations\_esg_0er_m", @"data\meshes\actors\character\animations\fnisbase", @"data\meshes\actors\character\behaviors", @"data\meshes\actors\character\character assets female", @"data\meshes\actors\character\character assets", @"data\meshes\actors\character\characters female", @"data\meshes\actors\character\characters", @"data\meshes\armor", @"data\meshes\armor\chesko", @"data\meshes\armor\naked", @"data\meshes\armor\weaponsling", @"data\meshes\clothes", @"data\meshes\clothes\cloaks", @"data\meshes\clothes\hdt test earring", @"data\meshes\clothes\horsecloak", @"data\meshes\hair", @"data\meshes\hair\clark", @"data\meshes\hair\fuse00hair", @"data\meshes\hair\havok physx", @"data\meshes\hair\hdt untitled hairs", @"data\meshes\hair\hhairstyles", @"data\meshes\hair\ks hairdo's", @"data\meshes\hair\skyrim hdt hair", @"data\meshes\hair\yoo", @"data\scripts", @"data\skse", @"data\skse\plugins", @"data\skse\plugins\campfiredata", @"data\skse\plugins\chargen", @"data\skse\plugins\frostfalldata", @"data\skse\plugins\wearablelanternsdata", @"data\skyproc patchers", @"data\skyproc patchers\dual sheath redux patch", @"data\tools", @"data\tools\generatefnis_for_users", @"data\tools\generatefnis_for_users\languages", @"data\tools\generatefnis_for_users\templates", @"data\tools\generatefnis_for_users\temporary_logs", @"enbseries", @"logs", @"skyrim", @"skyrim\cpfiles", @"skyrim\enb", @"skyrim\masterlist" };
        static List<string> IngoredSearchFoldersList = new List<string> { @"_programs", @"data\camerascripts", @"data\meshes\0sa", @"data\meshes\0sp", @"data\meshes\actors\character\animations\0sex_0mf_d", @"data\meshes\actors\character\animations\0sex_0mf_k", @"data\meshes\actors\character\animations\0sex_0mf_m", @"data\meshes\actors\character\animations\0sex_0mf_s", @"data\meshes\actors\character\animations\0sex_0mf_u", @"data\meshes\actors\character\animations\0sex_emf_a", @"data\meshes\actors\character\animations\_esg_0er_f", @"data\meshes\actors\character\animations\_esg_0er_m", @"data\meshes\actors\character\animations\fnisbase", @"data\meshes\actors\character\behaviors", @"data\meshes\armor\chesko", @"data\meshes\armor\naked", @"data\meshes\armor\weaponsling", @"data\meshes\clothes\cloaks", @"data\meshes\clothes\hdt test earring", @"data\meshes\clothes\horsecloak", @"data\meshes\hair\clark", @"data\meshes\hair\fuse00hair", @"data\meshes\hair\havok physx", @"data\meshes\hair\hdt untitled hairs", @"data\meshes\hair\hhairstyles", @"data\meshes\hair\ks hairdo's", @"data\meshes\hair\skyrim hdt hair", @"data\meshes\hair\yoo", @"data\skse\plugins\campfiredata", @"data\skse\plugins\chargen", @"data\skse\plugins\frostfalldata", @"data\skse\plugins\wearablelanternsdata", @"data\tools\generatefnis_for_users\languages", @"data\tools\generatefnis_for_users\templates", @"enbseries", @"skyrim\cpfiles", @"skyrim\enb", @"skyrim\masterlist" };
        public static void clearGameFolder()
        {
            CustomIgnoreList.Clear();
            if (File.Exists(FormMain.pathIgnoreINI))
            {
                CustomIgnoreList.AddRange(File.ReadAllLines(FormMain.pathIgnoreINI));
            }
            if (Directory.Exists(FormMain.pathGameFolder))
            {
                clearCurrentFolder("");
                searthAllForders(FormMain.pathGameFolder);
            }
        }
        static void searthAllForders(string startLocation)
        {
            if (Directory.Exists(startLocation))
            {
                foreach (string line in Directory.EnumerateDirectories(startLocation))
                {
                    string folderName = line.Remove(0, FormMain.pathGameFolder.Length);
                    if (folderName.Length > 0)
                    {
                        if (!IngoredSearchFoldersList.Contains(folderName, StringComparer.OrdinalIgnoreCase) && !CustomIgnoreList.Contains(folderName, StringComparer.OrdinalIgnoreCase))
                        {
                            searthAllForders(line);
                            clearCurrentFolder(folderName);
                        }
                    }
                }
            }
        }
        static void clearCurrentFolder(string clearpath)
        {
            if (Directory.Exists(FormMain.pathGameFolder + clearpath))
            {
                foreach (string line in Directory.EnumerateFiles(FormMain.pathGameFolder + clearpath))
                {
                    string fileName = line.Remove(0, FormMain.pathGameFolder.Length);
                    if (!IgnoreFilesList.Contains(fileName, StringComparer.OrdinalIgnoreCase) && !CustomIgnoreList.Contains(fileName, StringComparer.OrdinalIgnoreCase))
                    {
                        FuncFiles.deleteAny(line);
                    }
                }
                foreach (string line in Directory.EnumerateDirectories(FormMain.pathGameFolder + clearpath))
                {
                    string dirName = line.Remove(0, FormMain.pathGameFolder.Length);
                    if (!IgnoreFoldersList.Contains(dirName, StringComparer.OrdinalIgnoreCase) && !CustomIgnoreList.Contains(dirName, StringComparer.OrdinalIgnoreCase))
                    {
                        FuncFiles.deleteAny(line);
                    }
                }
            }
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static void emptyFolder(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (string line in Directory.GetDirectories(path))
                {
                    emptyFolder(line);
                    if (Directory.GetFiles(line).Length == 0 && Directory.GetDirectories(line).Length == 0)
                    {
                        FuncFiles.deleteAny(line);
                    }
                }
            }
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static void removeENB()
        {
            foreach (string line in new string[] { @"data\enb vision.bsa", @"data\enb vision.esp", "eed_verasansmono.bmp", "elep additional shaders", "enbinjector.exe", "enbpalettes", "enhancedenbdiagnostics.fxh", "fxaa_tool.exe", "fixforbrightobjects.txt", "smaa.fx", "smaa.h", "smaa_dx11.fx", "shader functions", "sweetfx", "sweetfx_d3d9.dll", "sweetfx_preset.txt", "sweetfx_settings.txt", "_locationweather.ini", "_mist_anchors.xml", "_sample_enbraindrops", "_weatherlist.ini", "common.fxh", "d3d9.dll", "d3d9.fx", "d3d9sffiles.dll", "d3d9_fxaa.dll", "d3d9_sffiles.dll", "d3d9_sfx.dll", "d3d9_sfx_fxaa.dll", "d3d9_sfx_smaa.dll", "d3d9_sharpen.dll", "d3d9_sweetffiles.dll", "d3d9_smaa.dll", "d3d9injffiles.dll", "d3d9orig.dll", "d3d9swe.dll", "defaultlut.png", "dxgi.dll", "dxgi.fx", "effect.txt", "effect.txt.ini", "enbbloom.fx", "enbbloom.fx.ini", "enbbloom.fx.rar", "enbdefs.fx", "enbdirt.bmp", "enbdirt.tga", "enbeffect.ffiles.ini", "enbeffect.fx", "enbeffect.fx.ini", "enbeffectprepass.fx", "enbeffectprepass.fx.ini", "enbeffectxx.fx.ini", "enbfontunicode.png", "enbfrost.bmp", "enbhelper.dll", "enbhost.exe", "enbinjector.ini", "enblens.fx", "enblens.fx.ini", "enblens1.fx", "enblensmask.bmp", "enblensmask.png", "enblensmask.tga", "enblocal.ini", "enblocalization.xml", "enbpalette.bmp", "enbpalette.png", "enbraindrops.tga", "enbseries", "enbseries.ini", "enbspectrum.bmp", "enbsunsprite.fx", "enbsunsprite.fx.ini", "enbsunsprite.tga", "enbweather.bmp", "injfx_settings.h", "injfx_shaders", "injector.ini", "shader.fx", "shift.dll", "sweetfx_d3d9.dll", "technique.fxh", "volumetric_mist_anchors.xml" })
            {
                FuncFiles.deleteAny(FormMain.pathGameFolder + line);
            }
        }
    }
}