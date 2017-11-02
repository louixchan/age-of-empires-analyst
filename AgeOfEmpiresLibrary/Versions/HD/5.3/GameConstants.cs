﻿using System;
namespace AgeOfEmpiresLibrary
{
	public static class GameConstants
	{
		public static byte[] CONSTANT = new byte[] { 0x9A, 0x99, 0x99, 0x99, 0x99, 0x99, 0xF9, 0x3F };
		public static byte[] SEPARATOR = new byte[] { 0x9D, 0xFF, 0xFF, 0xFF };
        public static byte[] SEPARATOR2 = new byte[] { 0x9D, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF , 0xFF, 0xFF, 0xFF , 0xFF, 0xFF };
		public static byte[] SCENARIO_CONSTANT = new byte[] { 0xF6, 0x28, 0x9C, 0x3F };
		public static byte[] AOK_SEPARATOR = new byte[] { 0x9A, 0x99, 0x99, 0x3F };
		public static byte[] AOE2_RECORD_SCENARIO_SEPARATOR = new byte[] { 0xAE, 0x47, 0xA1, 0x3F };
		public static byte[] AOE2_RECORD_HEADER_SEPARATOR = new byte[] { 0xA3, 0x5F, 0x02, 0x00 };
		public static byte[] AOE2_RECORD_HEADER_SEPARATOR_2 = new byte[] { 0x00, 0x00, 0x60, 0x0A };
        public static byte[] EXIST_OBJECT_SEPARATOR = new byte[] { 0x0B, 0x00, 0x08, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00 };
		public static byte[] OBJECT_END_SEPARATOR = new byte[] {
				0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x80, 0xBF, 0x00, 0x00, 0x80, 0xBF,
				0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
				0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }
		;
		public static byte[] AOK_OBJECT_END_SEPARATOR = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x80, 0xBF, 0x00
				, 0x00, 0x80, 0xBF, 0x00, 0x00, 0x00, 0x00, 0x00 }
		;
		public static byte[] GAIA_INFO_END_SEPARATOR = new byte[] { 0x00, 0x0B, 0x00, 0x02, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x0B };
		public static byte[] OBJECT_MID_SEPARATOR_GAIA = new byte[] { 0x00, 0x0B, 0x00, 0x40, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00 };
		public static byte[] PLAYER_INFO_END_SEPARATOR = new byte[] { 0x00, 0x0B, 0x40, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x0B, 0x00, 0x02, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x0B };

		// ROR Development
		public static byte[] LOBBY_INFO_SEPARATOR = new byte[] { 0x00, 0x60, 0x0A };
	}
}
