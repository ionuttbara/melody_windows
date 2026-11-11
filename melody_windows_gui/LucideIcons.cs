using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Melody
{
    // Embedded rasterizations of Lucide SVG art. No runtime SVG library/network/loose assets.
    internal static class LucideIcons
    {
        private static readonly Dictionary<string, Image> Cached = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);
        public static Image Get(string name, bool accent)
        {
            string key = name + (accent ? "-green" : "-light");
            lock (Cached)
            {
                Image value;
                if (Cached.TryGetValue(key, out value)) return value;
                string resource = "Melody.Lucide/" + key + ".png";
                using (Stream stream = typeof(LucideIcons).Assembly.GetManifestResourceStream(resource))
                {
                    if (stream == null) return null;
                    // Clone before closing stream; GDI+ otherwise may keep the stream alive.
                    using (Image original = Image.FromStream(stream))
                        value = new Bitmap(original);
                    Cached[key] = value;
                    return value;
                }
            }
        }

        // Cache sizes used by normal WinForms buttons/labels: no blurry oversized
        // icons and no per-paint bitmap allocations on the UI thread.
        public static Image GetSized(string name, bool accent, int pixels)
        {
            if (pixels <= 0 || pixels > 128) return null;
            string key = "sized:" + pixels + ":" + name + (accent ? ":green" : ":light");
            lock (Cached)
            {
                Image value;
                if (Cached.TryGetValue(key, out value)) return value;
                Image source = Get(name, accent);
                if (source == null) return null;
                value = new Bitmap(source, new Size(pixels, pixels));
                Cached[key] = value;
                return value;
            }
        }

        public static string CategoryIcon(string name)
        {
            string category = (name ?? "").ToLowerInvariant();
            if (category == "all tweaks") return "sliders-horizontal";
            if (category == "available") return "shield-check";
            if (category.Contains("bloat") || category.Contains("blotware")) return "package-x";
            if (category.Contains("windows update")) return "refresh-cw";
            if (category.Contains("office")) return "file-text";
            if (category.Contains("codecs")) return "audio-lines";
            if (category.Contains("taskbar")) return "panel-top";
            if (category.Contains("explorer")) return "folder-open";
            if (category.Contains("appearance") || category.Contains("apparence")) return "palette";
            if (category.Contains("telemetry")) return "activity";
            if (category.Contains("privacy")) return "eye-off";
            if (category.Contains("security")) return "shield-check";
            if (category.Contains("context menu")) return "menu";
            if (category.Contains("script")) return "terminal";
            if (category.Contains("virtual")) return "box";
            if (category.Contains("latency") || category.Contains("resource")) return "gauge";
            if (category.Contains("kernel") || category.Contains("gpu")) return "cpu";
            if (category.Contains("gaming")) return "gamepad-2";
            if (category.Contains("network")) return "network";
            if (category.Contains("cellular")) return "signal";
            if (category.Contains("device")) return "usb";
            if (category.Contains("input")) return "keyboard";
            if (category.Contains("browser")) return "globe";
            if (category.Contains("ai")) return "sparkles";
            if (category.Contains("search")) return "search";
            if (category.Contains("service")) return "server";
            if (category.Contains("task") || category.Contains("scheduler")) return "calendar-days";
            if (category.Contains("legacy")) return "archive";
            if (category.Contains("software") || category.Contains("application")) return "package";
            if (category.Contains("revertable") || category.Contains("revertible") || category.Contains("bug")) return "bug";
            if (category.Contains("system") || category.Contains("windows 11")) return "monitor-cog";
            if (category.Contains("window")) return "monitor";
            return "folder";
        }
    }
}
