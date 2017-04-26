﻿using System.Collections.Generic;
using System.Windows.Input;

namespace LoWeExposer.Handlers
{
    class KeyCodeConverter
    {

        internal static byte ToKeyCode(KeyEventArgs keyEventArgs)
        {
            var key = keyEventArgs.Key;

            if (key == Key.System)
                key = keyEventArgs.SystemKey;

            KeyCode value = KeyCode.KEY_NONE;
            _conversionTable.TryGetValue(key, out value);

            return (byte)value;
        }

        private static Dictionary<Key, KeyCode> _conversionTable = new Dictionary<Key, KeyCode>
        {
            { Key.Escape, KeyCode.KEY_ESC},
            { Key.D1, KeyCode.KEY_1},
            { Key.D2, KeyCode.KEY_2},
            { Key.D3, KeyCode.KEY_3},
            { Key.D4, KeyCode.KEY_4},
            { Key.D5, KeyCode.KEY_5},
            { Key.D6, KeyCode.KEY_6},
            { Key.D7, KeyCode.KEY_7},
            { Key.D8, KeyCode.KEY_8},
            { Key.D9, KeyCode.KEY_9},
            { Key.D0, KeyCode.KEY_0},
            { Key.OemMinus, KeyCode.KEY_MINUS},
            { Key.OemPlus, KeyCode.KEY_EQUAL},
            { Key.Back, KeyCode.KEY_BACKSPACE},
            { Key.Tab, KeyCode.KEY_TAB},
            { Key.Q, KeyCode.KEY_Q},
            { Key.W, KeyCode.KEY_W},
            { Key.E, KeyCode.KEY_E},
            { Key.R, KeyCode.KEY_R},
            { Key.T, KeyCode.KEY_T},
            { Key.Y, KeyCode.KEY_Y},
            { Key.U, KeyCode.KEY_U},
            { Key.I, KeyCode.KEY_I},
            { Key.O, KeyCode.KEY_O},
            { Key.P, KeyCode.KEY_P},
            { Key.Oem4, KeyCode.KEY_LEFTBRACE},
            { Key.Oem6, KeyCode.KEY_RIGHTBRACE},
            { Key.Enter, KeyCode.KEY_ENTER},
            { Key.LeftCtrl, KeyCode.KEY_LEFTCTRL},
            { Key.A, KeyCode.KEY_A},
            { Key.S, KeyCode.KEY_S},
            { Key.D, KeyCode.KEY_D},
            { Key.F, KeyCode.KEY_F},
            { Key.G, KeyCode.KEY_G},
            { Key.H, KeyCode.KEY_H},
            { Key.J, KeyCode.KEY_J},
            { Key.K, KeyCode.KEY_K},
            { Key.L, KeyCode.KEY_L},
            { Key.OemSemicolon, KeyCode.KEY_SEMICOLON},
            { Key.Oem7, KeyCode.KEY_APOSTROPHE},
//            { Key.Oem5, KeyCode.KEY_GRAVE},
            { Key.LeftShift, KeyCode.KEY_LEFTSHIFT},
            { Key.Oem5, KeyCode.KEY_BACKSLASH},
            { Key.Z, KeyCode.KEY_Z},
            { Key.X, KeyCode.KEY_X},
            { Key.C, KeyCode.KEY_C},
            { Key.V, KeyCode.KEY_V},
            { Key.B, KeyCode.KEY_B},
            { Key.N, KeyCode.KEY_N},
            { Key.M, KeyCode.KEY_M},
            { Key.OemComma, KeyCode.KEY_COMMA},
            { Key.OemPeriod, KeyCode.KEY_DOT},
            { Key.Oem2, KeyCode.KEY_SLASH},
            { Key.RightShift, KeyCode.KEY_RIGHTSHIFT},
            //{ Key., KeyCode.KEY_KPASTERISK},
            { Key.LeftAlt, KeyCode.KEY_LEFTALT},
            { Key.Space, KeyCode.KEY_SPACE},
            { Key.CapsLock, KeyCode.KEY_CAPSLOCK},
            { Key.F1, KeyCode.KEY_F1},
            { Key.F2, KeyCode.KEY_F2},
            { Key.F3, KeyCode.KEY_F3},
            { Key.F4, KeyCode.KEY_F4},
            { Key.F5, KeyCode.KEY_F5},
            { Key.F6, KeyCode.KEY_F6},
            { Key.F7, KeyCode.KEY_F7},
            { Key.F8, KeyCode.KEY_F8},
            { Key.F9, KeyCode.KEY_F9},
            { Key.F10, KeyCode.KEY_F10},
            { Key.NumLock, KeyCode.KEY_NUMLOCK},
            { Key.Scroll, KeyCode.KEY_SCROLLLOCK},
            { Key.NumPad7, KeyCode.KEY_KP7},
            { Key.NumPad8, KeyCode.KEY_KP8},
            { Key.NumPad9, KeyCode.KEY_KP9},
            //{ Key.OemMinus, KeyCode.KEY_KPMINUS},
            { Key.NumPad4, KeyCode.KEY_KP4},
            { Key.NumPad5, KeyCode.KEY_KP5},
            { Key.NumPad6, KeyCode.KEY_KP6},
            //{ Key.OemPlus, KeyCode.KEY_KPPLUS},
            { Key.NumPad1, KeyCode.KEY_KP1},
            { Key.NumPad2, KeyCode.KEY_KP2},
            { Key.NumPad3, KeyCode.KEY_KP3},
            { Key.NumPad0, KeyCode.KEY_KP0},
            //{ Key.OemPeriod, KeyCode.KEY_KPDOT},
            { Key.F11, KeyCode.KEY_F11},
            { Key.F12, KeyCode.KEY_F12},
            //{ Key.Enter, KeyCode.KEY_KPENTER},
            { Key.RightCtrl, KeyCode.KEY_RIGHTCTRL},
            //{ Key., KeyCode.KEY_KPSLASH},
//            { Key.Pause, KeyCode.KEY_SYSRQ},
            { Key.RightAlt, KeyCode.KEY_RIGHTALT},
            { Key.Home, KeyCode.KEY_HOME},
            { Key.Up, KeyCode.KEY_UP},
            { Key.PageUp, KeyCode.KEY_PAGEUP},
            { Key.Left, KeyCode.KEY_LEFT},
            { Key.Right, KeyCode.KEY_RIGHT},
            { Key.End, KeyCode.KEY_END},
            { Key.Down, KeyCode.KEY_DOWN},
            { Key.PageDown, KeyCode.KEY_PAGEDOWN},
            { Key.Insert, KeyCode.KEY_INSERT},
            { Key.Delete, KeyCode.KEY_DELETE},
//            { , KeyCode.KEY_KPEQUAL},
  //          { , KeyCode.KEY_KPPLUSMINUS},
            { Key.Pause, KeyCode.KEY_PAUSE},
        };

        private enum KeyCode : byte
        {
            KEY_NONE = 0,
            KEY_ESC = 1,
            KEY_1 = 2,
            KEY_2 = 3,
            KEY_3 = 4,
            KEY_4 = 5,
            KEY_5 = 6,
            KEY_6 = 7,
            KEY_7 = 8,
            KEY_8 = 9,
            KEY_9 = 10,
            KEY_0 = 11,
            KEY_MINUS = 12,
            KEY_EQUAL = 13,
            KEY_BACKSPACE = 14,
            KEY_TAB = 15,
            KEY_Q = 16,
            KEY_W = 17,
            KEY_E = 18,
            KEY_R = 19,
            KEY_T = 20,
            KEY_Y = 21,
            KEY_U = 22,
            KEY_I = 23,
            KEY_O = 24,
            KEY_P = 25,
            KEY_LEFTBRACE = 26,
            KEY_RIGHTBRACE = 27,
            KEY_ENTER = 28,
            KEY_LEFTCTRL = 29,
            KEY_A = 30,
            KEY_S = 31,
            KEY_D = 32,
            KEY_F = 33,
            KEY_G = 34,
            KEY_H = 35,
            KEY_J = 36,
            KEY_K = 37,
            KEY_L = 38,
            KEY_SEMICOLON = 39,
            KEY_APOSTROPHE = 40,
            KEY_GRAVE = 41,
            KEY_LEFTSHIFT = 42,
            KEY_BACKSLASH = 43,
            KEY_Z = 44,
            KEY_X = 45,
            KEY_C = 46,
            KEY_V = 47,
            KEY_B = 48,
            KEY_N = 49,
            KEY_M = 50,
            KEY_COMMA = 51,
            KEY_DOT = 52,
            KEY_SLASH = 53,
            KEY_RIGHTSHIFT = 54,
            KEY_KPASTERISK = 55,
            KEY_LEFTALT = 56,
            KEY_SPACE = 57,
            KEY_CAPSLOCK = 58,
            KEY_F1 = 59,
            KEY_F2 = 60,
            KEY_F3 = 61,
            KEY_F4 = 62,
            KEY_F5 = 63,
            KEY_F6 = 64,
            KEY_F7 = 65,
            KEY_F8 = 66,
            KEY_F9 = 67,
            KEY_F10 = 68,
            KEY_NUMLOCK = 69,
            KEY_SCROLLLOCK = 70,
            KEY_KP7 = 71,
            KEY_KP8 = 72,
            KEY_KP9 = 73,
            KEY_KPMINUS = 74,
            KEY_KP4 = 75,
            KEY_KP5 = 76,
            KEY_KP6 = 77,
            KEY_KPPLUS = 78,
            KEY_KP1 = 79,
            KEY_KP2 = 80,
            KEY_KP3 = 81,
            KEY_KP0 = 82,
            KEY_KPDOT = 83,
            KEY_ZENKAKUHANKAKU = 85,
            KEY_F11 = 87,
            KEY_F12 = 88,
            KEY_KPENTER = 96,
            KEY_RIGHTCTRL = 97,
            KEY_KPSLASH = 98,
            KEY_SYSRQ = 99,
            KEY_RIGHTALT = 100,
            KEY_LINEFEED = 101,
            KEY_HOME = 102,
            KEY_UP = 103,
            KEY_PAGEUP = 104,
            KEY_LEFT = 105,
            KEY_RIGHT = 106,
            KEY_END = 107,
            KEY_DOWN = 108,
            KEY_PAGEDOWN = 109,
            KEY_INSERT = 110,
            KEY_DELETE = 111,
            KEY_MACRO = 112,
            KEY_MUTE = 113,
            KEY_KPEQUAL = 117,
            KEY_KPPLUSMINUS = 118,
            KEY_PAUSE = 119
        }
    }
}
