﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █      ▄█    █▄                                    ▄███████▄
      █     ███    ███                                  ███    ███
      █     ███    ███      ▄█████  █          █████▄   ███    ███    █████  █  ██▄▄▄▄      ██       ▄█████    █████
      █    ▄███▄▄▄▄███▄▄   ██   █  ██         ██   ██   ███    ███   ██  ██ ██  ██▀▀▀█▄ ▀███████▄   ██   █    ██  ██
      █   ▀▀███▀▀▀▀███▀   ▄██▄▄    ██         ██   ██ ▀█████████▀   ▄██▄▄█▀ ██▌ ██   ██     ██  ▀  ▄██▄▄     ▄██▄▄█▀
      █     ███    ███   ▀▀██▀▀    ██       ▀██████▀    ███        ▀███████ ██  ██   ██     ██    ▀▀██▀▀    ▀███████
      █     ███    ███     ██   █  ██▌    ▄   ██        ███          ██  ██ ██  ██   ██     ██      ██   █    ██  ██
      █     ███    █▀      ███████ ████▄▄██  ▄███▀     ▄████▀        ██  ██ █    █   █     ▄██▀     ███████   ██  ██
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Prints help messages for the Application to the console.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The GNU Affero General Public License (GNU AGPL)
      █
      █  Copyright (C) 2016-2017 JP Dillingham (jp@dillingham.ws)
      █
      █  This program is free software: you can redistribute it and/or modify
      █  it under the terms of the GNU Affero General Public License as published by
      █  the Free Software Foundation, either version 3 of the License, or
      █  (at your option) any later version.
      █
      █  This program is distributed in the hope that it will be useful,
      █  but WITHOUT ANY WARRANTY; without even the implied warranty of
      █  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      █  GNU Affero General Public License for more details.
      █
      █  You should have received a copy of the GNU Affero General Public License
      █  along with this program.  If not, see <http://www.gnu.org/licenses/>.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                            */

using System;
using Utility.BigFont;

namespace OpenIIoT.Packager.Tools
{
    /// <summary>
    ///     Prints help messages for the Application to the console.
    /// </summary>
    public static class HelpPrinter
    {
        #region Private Fields

        /// <summary>
        ///     Shorthand method for line breaks.
        /// </summary>
        private static Action lineBreak = () => Console.WriteLine("   │");

        /// <summary>
        ///     Shorthand method for prefixed messages.
        /// </summary>
        private static Action<string> prefixed = (s) => Console.WriteLine("   │ " + s);

        /// <summary>
        ///     Shorthand method for spaced (but not prefixed) messages.
        /// </summary>
        private static Action<string> spaced = (s) => Console.WriteLine("   " + s);

        #endregion Private Fields

        #region Public Methods

        /// <summary>
        ///     Prints the help message for the specified command, or a list of commands if a null or invalid command is specified.
        /// </summary>
        /// <param name="command">The command for which the help message is to be printed.</param>
        public static void PrintHelp(string command = default(string))
        {
            switch (command)
            {
                case "manifest":
                    PrintManifestHelp();
                    return;

                case "package":
                    PrintPackageHelp();
                    return;

                case "sign":
                    PrintSignHelp();
                    return;

                case "verify":
                    PrintVerifyHelp();
                    return;

                case "trust":
                    PrintTrustHelp();
                    return;

                case "verify-trust":
                    PrintVerifyTrustHelp();
                    return;

                default:
                    PrintCommands();
                    return;
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        ///     Prints a list of available commands.
        /// </summary>
        private static void PrintCommands()
        {
            PrintTitle("Commands");
            PrintHeader();

            prefixed("> manifest\t\tGenerate a package manifest file.");
            prefixed("> package\t\tCreate a package file.");
            prefixed("> sign\t\tDigitally sign a package file.");
            prefixed("> verify\t\tVerify the integrity of a package file.");
            prefixed("> trust\t\tAdd a trust to a signed package file.");
            prefixed("> verify-trust\tVerify a trusted package file.");

            lineBreak();
            prefixed("! use 'help <command>' to get more details about that command.");

            PrintFooter();
        }

        /// <summary>
        ///     Prints a section footer.
        /// </summary>
        private static void PrintFooter()
        {
            spaced("└───────────────────── ── ─────────────── ─── ─ ─  ─   ─");
        }

        /// <summary>
        ///     Prints a section header.
        /// </summary>
        private static void PrintHeader()
        {
            spaced("┌─────────────────────── ─ ─── ───────────────────── ── ───── ─ ───   ──");
        }

        /// <summary>
        ///     Prints the help message for the "manifest" command.
        /// </summary>
        private static void PrintManifestHelp()
        {
            PrintTitle("Manifest");
            PrintHeader();

            prefixed("> manifest");
            lineBreak();

            prefixed("[-d|--directory <directory>]\tDirectory containing payload files.");
            prefixed("[-i|--include-resources]\t\tIncludes non-binary/web files.");
            prefixed("[-h|--hash]\t\t\tMarks files to be hashed during packaging.");
            prefixed("[-o|--output <file>]\t\tOutput manifest file.");

            lineBreak();
            prefixed("! ex: 'manifest -hi -d \"desktop\\coolPlugin\" -o \"manifest.json\"'");
            PrintFooter();
        }

        /// <summary>
        ///     Prints the help message for the "package" command.
        /// </summary>
        private static void PrintPackageHelp()
        {
            PrintTitle("Package");
            PrintHeader();

            prefixed("> package");
            lineBreak();

            prefixed("<directory>\tDirectory containing payload files.");
            prefixed("<manifest>\t\tThe manifest for the package (manifest.json, generate with 'manifest')");
            prefixed("<output file>\tOutput package file (*.opkg).");

            lineBreak();
            prefixed("! ex: 'package \"desktop\\coolPlugin\" \"manifest.json\" \"coolPlugin.opkg\"'");
            PrintFooter();
        }

        /// <summary>
        ///     Prints the help message for the "sign" command.
        /// </summary>
        private static void PrintSignHelp()
        {
            PrintTitle("Sign");
            PrintHeader();

            prefixed("> sign");
            lineBreak();

            prefixed("<package>\t\tThe package to sign.");
            prefixed("<public key file>\tThe ASCII-armored PGP public key file.");
            prefixed("<private key file>\tThe ASCII-armored PGP private key file.");

            lineBreak();
            prefixed("! ex: 'sign \"coolPlugin.opkg\" \"publicKey.asc\" \"privateKey.asc\"");
            PrintFooter();
        }

        /// <summary>
        ///     Prints a section title for the specified command.
        /// </summary>
        /// <param name="title">The desired title.</param>
        private static void PrintTitle(string title)
        {
            string[] lines = BigFontGenerator.Generate(title, Font.Graffiti, FontSize.Small);

            Console.WriteLine("\n");

            foreach (string line in lines)
            {
                Console.WriteLine(" " + line);
            }
        }

        /// <summary>
        ///     Prints the help message for the "trust" command.
        /// </summary>
        private static void PrintTrustHelp()
        {
            PrintTitle("Trust");
            PrintHeader();

            prefixed("> trust");
            lineBreak();

            prefixed("<package>\t\tThe package to trust.");
            prefixed("<private key file>\tThe ASCII-armored PGP private key file.");

            lineBreak();
            prefixed("! ex: 'verify \"coolPlugin.opkg\" \"privateKey.asc\"'");
            PrintFooter();
        }

        /// <summary>
        ///     Prints the help message for the "verify" command.
        /// </summary>
        private static void PrintVerifyHelp()
        {
            PrintTitle("Verify");
            PrintHeader();

            prefixed("> verify");
            lineBreak();

            prefixed("<package>\t\tThe package to verify.");

            lineBreak();
            prefixed("! ex: 'verify \"coolPlugin.opkg\"'");
            PrintFooter();
        }

        /// <summary>
        ///     Prints the help message for the "verify-trust" command.
        /// </summary>
        private static void PrintVerifyTrustHelp()
        {
            PrintTitle("Verify-Trust");
            PrintHeader();

            prefixed("> verify-trust");
            lineBreak();

            prefixed("<package>\t\tThe package to verify.");

            lineBreak();
            prefixed("! ex: 'verify-trust \"coolPlugin.opkg\"'");
            PrintFooter();
        }

        #endregion Private Methods
    }
}