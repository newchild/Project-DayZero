using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns25;
using ns26;
using ns29;
using ns3;
using ns40;
using ns6;
using ns64;
using ns7;
using ns77;
using ns79;
using ns8;
using ns80;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns78
{
	// Token: 0x02000656 RID: 1622
	internal sealed class Class861 : IDisposable, ICloneable, IComparable<Class861>
	{
		// Token: 0x02000657 RID: 1623
		[CompilerGenerated]
		private sealed class Class862
		{
			// Token: 0x04002DC4 RID: 11716
			public Class537 class537_0;

			// Token: 0x04002DC5 RID: 11717
			public float float_0;

			// Token: 0x0600320B RID: 12811
			// RVA: 0x00024E28 File Offset: 0x00023028
			public void method_0()
			{
				this.class537_0.float_2 = this.float_0 / (float)Math.Max(this.class537_0.int_6, this.class537_0.int_5);
			}
		}

		// Token: 0x04002D91 RID: 11665
		internal bool bool_0;

		// Token: 0x04002D94 RID: 11668
		private bool bool_1;

		// Token: 0x04002DBF RID: 11711
		public bool bool_10 = true;

		// Token: 0x04002D95 RID: 11669
		private bool bool_2 = true;

		// Token: 0x04002D99 RID: 11673
		internal bool bool_3;

		// Token: 0x04002D9A RID: 11674
		internal bool bool_4;

		// Token: 0x04002DB0 RID: 11696
		internal bool bool_5;

		// Token: 0x04002DB1 RID: 11697
		internal bool bool_6;

		// Token: 0x04002DB5 RID: 11701
		internal bool bool_7 = true;

		// Token: 0x04002DB6 RID: 11702
		internal bool bool_8 = true;

		// Token: 0x04002DBA RID: 11706
		internal bool bool_9;

		// Token: 0x04002DB2 RID: 11698
		internal bStatus bStatus_0;

		// Token: 0x04002D9C RID: 11676
		private Class531 class531_0;

		// Token: 0x04002D9D RID: 11677
		private Class531 class531_1;

		// Token: 0x04002DA8 RID: 11688
		internal Class531 class531_2;

		// Token: 0x04002DA9 RID: 11689
		private Class531 class531_3;

		// Token: 0x04002DB8 RID: 11704
		private Class531 class531_4;

		// Token: 0x04002DAA RID: 11690
		internal Class533 class533_0;

		// Token: 0x04002DAC RID: 11692
		private Class533 class533_1;

		// Token: 0x04002DAD RID: 11693
		private Class533 class533_2;

		// Token: 0x04002DAF RID: 11695
		private Class533 class533_3;

		// Token: 0x04002DB7 RID: 11703
		private Class533 class533_4;

		// Token: 0x04002DA7 RID: 11687
		private Class537 class537_0;

		// Token: 0x04002DAB RID: 11691
		internal Class911 class911_0 = Class115.class911_2;

		// Token: 0x04002D8E RID: 11662
		private Color color_0 = new Color(10, 29, 75);

		// Token: 0x04002D8D RID: 11661
		internal double double_0;

		// Token: 0x04002DA0 RID: 11680
		internal Enum30 enum30_0;

		// Token: 0x04002DC0 RID: 11712
		[CompilerGenerated]
		private static EventHandler eventHandler_0;

		// Token: 0x04002D9B RID: 11675
		internal float float_0;

		// Token: 0x04002DBB RID: 11707
		internal float float_1;

		// Token: 0x04002DBC RID: 11708
		internal float float_2;

		// Token: 0x04002D8F RID: 11663
		internal int int_0;

		// Token: 0x04002D96 RID: 11670
		internal int int_1;

		// Token: 0x04002DA1 RID: 11681
		internal int int_2;

		// Token: 0x04002DA3 RID: 11683
		internal int int_3;

		// Token: 0x04002DB4 RID: 11700
		internal int int_4;

		// Token: 0x04002DBD RID: 11709
		public int int_5;

		// Token: 0x04002DAE RID: 11694
		internal List<Class531> list_0;

		// Token: 0x04002D8B RID: 11659
		private static readonly long[] long_0 = new long[]
		{
			30000L,
			100000L,
			210000L,
			360000L,
			550000L,
			780000L,
			1050000L,
			1360000L,
			1710000L,
			2100000L,
			2530000L,
			3000000L,
			3510000L,
			4060000L,
			4650000L,
			5280000L,
			5950000L,
			6660000L,
			7410000L,
			8200000L,
			9030000L,
			9900000L,
			10810000L,
			11760000L,
			12750000L,
			13780000L,
			14850000L,
			15960000L,
			17110000L,
			18300000L,
			19530000L,
			20800000L,
			22110000L,
			23460000L,
			24850000L,
			26280000L,
			27750000L,
			29260000L,
			30810000L,
			32400000L,
			34030000L,
			35700000L,
			37410000L,
			39160000L,
			40950000L,
			42780000L,
			44650000L,
			46560000L,
			48510000L,
			50500000L,
			52530000L,
			54600000L,
			56710000L,
			58860000L,
			61050000L,
			63280000L,
			65550000L,
			67860000L,
			70210001L,
			72600001L,
			75030002L,
			77500003L,
			80010006L,
			82560010L,
			85150019L,
			87780034L,
			90450061L,
			93160110L,
			95910198L,
			98700357L,
			101530643L,
			104401157L,
			107312082L,
			110263748L,
			113256747L,
			116292144L,
			119371859L,
			122499346L,
			125680824L,
			128927482L,
			132259468L,
			135713043L,
			139353477L,
			143298259L,
			147758866L,
			153115959L,
			160054726L,
			169808506L,
			184597311L,
			208417160L,
			248460887L,
			317675597L,
			439366075L,
			655480935L,
			1041527682L,
			1733419828L,
			2975801691L,
			5209033044L,
			9225761479L,
			99999999999L,
			99999999999L,
			99999999999L,
			99999999999L,
			99999999999L,
			99999999999L,
			99999999999L,
			99999999999L,
			99999999999L,
			99999999999L
		};

		// Token: 0x04002DA4 RID: 11684
		private long long_1;

		// Token: 0x04002D93 RID: 11667
		internal Mods mods_0;

		// Token: 0x04002DA2 RID: 11682
		internal PlayModes playModes_0;

		// Token: 0x04002DC1 RID: 11713
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x04002DC2 RID: 11714
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x04002DC3 RID: 11715
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x04002DA5 RID: 11685
		private short short_0;

		// Token: 0x04002D8C RID: 11660
		private static string[] string_0 = new string[]
		{
			"Unknown",
			"Oceania",
			"Europe",
			"Andorra",
			"UAE",
			"Afghanistan",
			"Antigua",
			"Anguilla",
			"Albania",
			"Armenia",
			"Netherlands Antilles",
			"Angola",
			"Antarctica",
			"Argentina",
			"American Samoa",
			"Austria",
			"Australia",
			"Aruba",
			"Azerbaijan",
			"Bosnia",
			"Barbados",
			"Bangladesh",
			"Belgium",
			"Burkina Faso",
			"Bulgaria",
			"Bahrain",
			"Burundi",
			"Benin",
			"Bermuda",
			"Brunei Darussalam",
			"Bolivia",
			"Brazil",
			"Bahamas",
			"Bhutan",
			"Bouvet Island",
			"Botswana",
			"Belarus",
			"Belize",
			"Canada",
			"Cocos Islands",
			"Congo",
			"Central African Republic",
			"Congo",
			"Switzerland",
			"Cote D'Ivoire",
			"Cook Islands",
			"Chile",
			"Cameroon",
			"China",
			"Colombia",
			"Costa Rica",
			"Cuba",
			"Cape Verde",
			"Christmas Island",
			"Cyprus",
			"Czech Republic",
			"Germany",
			"Djibouti",
			"Denmark",
			"Dominica",
			"Dominican Republic",
			"Algeria",
			"Ecuador",
			"Estonia",
			"Egypt",
			"Western Sahara",
			"Eritrea",
			"Spain",
			"Ethiopia",
			"Finland",
			"Fiji",
			"Falkland Islands",
			"Micronesia, Federated States of",
			"Faroe Islands",
			"France",
			"France, Metropolitan",
			"Gabon",
			"United Kingdom",
			"Grenada",
			"Georgia",
			"French Guiana",
			"Ghana",
			"Gibraltar",
			"Greenland",
			"Gambia",
			"Guinea",
			"Guadeloupe",
			"Equatorial Guinea",
			"Greece",
			"South Georgia",
			"Guatemala",
			"Guam",
			"Guinea-Bissau",
			"Guyana",
			"Hong Kong",
			"Heard Island",
			"Honduras",
			"Croatia",
			"Haiti",
			"Hungary",
			"Indonesia",
			"Ireland",
			"Israel",
			"India",
			"British Indian Ocean Territory",
			"Iraq",
			"Iran, Islamic Republic of",
			"Iceland",
			"Italy",
			"Jamaica",
			"Jordan",
			"Japan",
			"Kenya",
			"Kyrgyzstan",
			"Cambodia",
			"Kiribati",
			"Comoros",
			"St. Kitts and Nevis",
			"Korea, Democratic People's Republic of",
			"Korea",
			"Kuwait",
			"Cayman Islands",
			"Kazakhstan",
			"Lao",
			"Lebanon",
			"St. Lucia",
			"Liechtenstein",
			"Sri Lanka",
			"Liberia",
			"Lesotho",
			"Lithuania",
			"Luxembourg",
			"Latvia",
			"Libyan Arab Jamahiriya",
			"Morocco",
			"Monaco",
			"Moldova, Republic of",
			"Madagascar",
			"Marshall Islands",
			"Macedonia, the Former Yugoslav Republic of",
			"Mali",
			"Myanmar",
			"Mongolia",
			"Macau",
			"Northern Mariana Islands",
			"Martinique",
			"Mauritania",
			"Montserrat",
			"Malta",
			"Mauritius",
			"Maldives",
			"Malawi",
			"Mexico",
			"Malaysia",
			"Mozambique",
			"Namibia",
			"New Caledonia",
			"Niger",
			"Norfolk Island",
			"Nigeria",
			"Nicaragua",
			"Netherlands",
			"Norway",
			"Nepal",
			"Nauru",
			"Niue",
			"New Zealand",
			"Oman",
			"Panama",
			"Peru",
			"French Polynesia",
			"Papua New Guinea",
			"Philippines",
			"Pakistan",
			"Poland",
			"St. Pierre",
			"Pitcairn",
			"Puerto Rico",
			"Palestinian Territory",
			"Portugal",
			"Palau",
			"Paraguay",
			"Qatar",
			"Reunion",
			"Romania",
			"Russian Federation",
			"Rwanda",
			"Saudi Arabia",
			"Solomon Islands",
			"Seychelles",
			"Sudan",
			"Sweden",
			"Singapore",
			"St. Helena",
			"Slovenia",
			"Svalbard and Jan Mayen",
			"Slovakia",
			"Sierra Leone",
			"San Marino",
			"Senegal",
			"Somalia",
			"Suriname",
			"Sao Tome and Principe",
			"El Salvador",
			"Syrian Arab Republic",
			"Swaziland",
			"Turks and Caicos Islands",
			"Chad",
			"French Southern Territories",
			"Togo",
			"Thailand",
			"Tajikistan",
			"Tokelau",
			"Turkmenistan",
			"Tunisia",
			"Tonga",
			"Timor-Leste",
			"Turkey",
			"Trinidad and Tobago",
			"Tuvalu",
			"Taiwan",
			"Tanzania",
			"Ukraine",
			"Uganda",
			"US (Island)",
			"United States",
			"Uruguay",
			"Uzbekistan",
			"Holy See",
			"St. Vincent",
			"Venezuela",
			"Virgin Islands, British",
			"Virgin Islands, U.S.",
			"Vietnam",
			"Vanuatu",
			"Wallis and Futuna",
			"Samoa",
			"Yemen",
			"Mayotte",
			"Serbia",
			"South Africa",
			"Zambia",
			"Montenegro",
			"Zimbabwe",
			"Unknown",
			"Satellite Provider",
			"Other",
			"Aland Islands",
			"Guernsey",
			"Isle of Man",
			"Jersey",
			"St. Barthelemy",
			"Saint Martin"
		};

		// Token: 0x04002D90 RID: 11664
		internal string string_1 = string.Empty;

		// Token: 0x04002D92 RID: 11666
		internal string string_2 = string.Empty;

		// Token: 0x04002D97 RID: 11671
		private string string_3 = string.Empty;

		// Token: 0x04002D98 RID: 11672
		internal string string_4;

		// Token: 0x04002D9E RID: 11678
		internal string string_5;

		// Token: 0x04002D9F RID: 11679
		private string string_6;

		// Token: 0x04002DA6 RID: 11686
		private string string_7;

		// Token: 0x04002DB3 RID: 11699
		private string string_8 = string.Empty;

		// Token: 0x04002DB9 RID: 11705
		internal static string string_9 = Class41.GetString(OsuString.General_Loading);

		// Token: 0x04002DBE RID: 11710
		private Vector2 vector2_0;

		// Token: 0x170003AC RID: 940
		public string Name
		{
			// Token: 0x060031E5 RID: 12773
			// RVA: 0x00024D20 File Offset: 0x00022F20
			get
			{
				return this.string_6;
			}
			// Token: 0x060031E6 RID: 12774
			// RVA: 0x00024D28 File Offset: 0x00022F28
			set
			{
				this.string_6 = value;
				this.string_4 = value.Replace(' ', '_');
			}
		}

		// Token: 0x060031EB RID: 12779
		// RVA: 0x00146CA8 File Offset: 0x00144EA8
		internal Class861()
		{
		}

		// Token: 0x060031ED RID: 12781
		// RVA: 0x00024D7D File Offset: 0x00022F7D
		internal Class861(string string_10) : this(-1, string_10)
		{
		}

		// Token: 0x060031EE RID: 12782
		// RVA: 0x00024D87 File Offset: 0x00022F87
		internal Class861(Class17 class17_0) : this(class17_0, null)
		{
		}

		// Token: 0x060031EC RID: 12780
		// RVA: 0x00146D20 File Offset: 0x00144F20
		internal Class861(int int_6, string string_10)
		{
			this.bool_4 = false;
			this.int_1 = int_6;
			this.Name = (string_10 ?? Class861.string_9);
		}

		// Token: 0x060031EF RID: 12783
		// RVA: 0x00146DB8 File Offset: 0x00144FB8
		internal Class861(Class17 class17_0, Class19 class19_0)
		{
			this.bool_4 = class17_0.bool_0;
			this.bool_1 = true;
			this.method_5(class17_0);
			if (class19_0 != null)
			{
				this.method_6(class19_0);
			}
		}

		// Token: 0x06003201 RID: 12801
		// RVA: 0x00148640 File Offset: 0x00146840
		public object Clone()
		{
			Class861 class = base.MemberwiseClone() as Class861;
			class.method_17();
			return class;
		}

		// Token: 0x060031F0 RID: 12784
		// RVA: 0x00146E54 File Offset: 0x00145054
		public int CompareTo(Class861 obj)
		{
			int num = this.Name.CompareTo(obj.Name);
			if (num != 0)
			{
				return num;
			}
			return this.int_1.CompareTo(obj.int_1);
		}

		// Token: 0x060031F1 RID: 12785
		// RVA: 0x00024D91 File Offset: 0x00022F91
		public void Dispose()
		{
			this.Dispose(false);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060031F3 RID: 12787
		// RVA: 0x00146EBC File Offset: 0x001450BC
		internal void Dispose(bool bool_11)
		{
			if (this.class533_1 != null)
			{
				this.class533_1.Dispose();
			}
			if (this.class533_0 != null)
			{
				this.class533_0.Dispose();
			}
			if (this.class533_3 != null)
			{
				this.class533_3.Dispose();
			}
			if (this.class533_2 != null)
			{
				this.class533_2.Dispose();
			}
		}

		// Token: 0x060031F2 RID: 12786
		// RVA: 0x00146E8C File Offset: 0x0014508C
		~Class861()
		{
			this.Dispose(true);
		}

		// Token: 0x060031E7 RID: 12775
		// RVA: 0x00024D41 File Offset: 0x00022F41
		internal double method_0()
		{
			if (this.bool_5 && this.short_0 > 0)
			{
				return Math.Pow((double)this.short_0, 0.4) * 0.195;
			}
			return 0.0;
		}

		// Token: 0x060031E8 RID: 12776
		// RVA: 0x00146A70 File Offset: 0x00144C70
		private void method_1()
		{
			VoidDelegate voidDelegate = null;
			Vector2 vector = this.vector2_0;
			Vector2 vector2;
			vector2..ctor(23f, 23f);
			float float_ = (this.class531_2 != null) ? (this.class531_2.float_0 + 1E-06f) : 0f;
			if (this.class537_0 != null)
			{
				this.class537_0.vector2_0 = vector + vector2;
				if (this.class537_0.vmethod_6() == null)
				{
					Class537 arg_79_0 = this.class537_0;
					if (voidDelegate == null)
					{
						voidDelegate = new VoidDelegate(this.method_19);
					}
					arg_79_0.method_55(voidDelegate);
				}
				this.class537_0.float_2 = 74f / (float)Math.Max(this.class537_0.int_6, this.class537_0.int_5);
			}
			else
			{
				this.class537_0 = this.method_2(vector + vector2, float_, 74f);
				if (this.list_0 != null)
				{
					this.list_0.Add(this.class537_0);
				}
			}
			this.class537_0.vector2_1 = this.vector2_0 + vector2;
			this.class537_0.origins_0 = Origins.Centre;
		}

		// Token: 0x060031FA RID: 12794
		// RVA: 0x00147B48 File Offset: 0x00145D48
		internal bool method_10(Vector2 vector2_1, bool bool_11, int int_6)
		{
			this.bool_1 = bool_11;
			this.vector2_0 = vector2_1;
			if (this.list_0 == null)
			{
				this.list_0 = new List<Class531>();
				float num = 0.92f + (float)int_6 * 0.0001f;
				Vector2 vector;
				vector..ctor(-4f, -4f);
				this.class531_2 = new Class531(Class885.Load("user-bg", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_1 + vector, num, true, new Color(this.color_0.get_R(), this.color_0.get_G(), this.color_0.get_B(), this.bool_7 ? 200 : 0), null);
				Class530 arg_C1_0 = this.class531_2;
				if (Class861.eventHandler_0 == null)
				{
					Class861.eventHandler_0 = new EventHandler(Class861.smethod_0);
				}
				arg_C1_0.method_2(Class861.eventHandler_0);
				this.list_0.Add(this.class531_2);
				this.class531_3 = new Class531(Class885.Load("user-border", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_1 + vector, num + 2E-06f, true, new Color(0, 0, 0, this.bool_7 ? 255 : 0), null);
				this.list_0.Add(this.class531_3);
				this.class533_1 = new Class533(this.Name, 14f, vector2_1 + new Vector2(48f, -2f), Vector2.get_Zero(), num + 3E-06f, true, new Color(255, 255, 255, this.bool_7 ? 255 : 0), true);
				this.list_0.Add(this.class533_1);
				this.class533_1.method_63(true);
				this.class533_0 = new Class533(this.string_3, 10f, vector2_1 + new Vector2(48f, 12f), new Vector2(150f, 33f), num + 3E-06f, true, new Color(255, 255, 255, this.bool_7 ? 255 : 0), true);
				this.class533_0.method_63(true);
				this.class533_0.int_0 = 2;
				this.list_0.Add(this.class533_0);
				this.class533_2 = new Class533(this.string_7, 36f, vector2_1 + new Vector2(204f, (float)(this.bool_1 ? 14 : 7)), Vector2.get_Zero(), num + 1E-06f, true, new Color(255, 255, 255, this.bool_7 ? 255 : 0), false);
				this.class533_2.origins_0 = Origins.TopRight;
				this.class533_2.method_63(true);
				this.list_0.Add(this.class533_2);
				this.class531_4 = new Class531(this.method_11(), Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_1 + new Vector2(176f, 0f), num + 2E-06f, true, new Color(255, 255, 255, this.bool_7 ? 70 : 0), null)
				{
					int_0 = 1
				};
				this.list_0.Add(this.class531_4);
				this.method_1();
				if (this.bool_1)
				{
					this.class533_3 = new Class533(this.string_8, 10f, vector2_1 + new Vector2(48f, 12f), new Vector2(150f, 32f), num + 4E-06f, true, new Color(255, 255, 255, 0), true);
					this.class533_3.method_63(true);
					this.class533_3.int_0 = 1;
					this.list_0.Add(this.class533_3);
					this.class531_2.method_35(new EventHandler(this.method_14));
					this.class531_2.method_37(new EventHandler(this.method_13));
				}
				else
				{
					this.class531_0 = new Class531(Class885.Load("levelbar-bg", Enum112.flag_1), vector2_1, num + 3E-06f, true, new Color(255, 255, 255, (!this.bool_7 || bool_11) ? 0 : 255));
					this.class531_0.vector2_5 = new Vector2(-120f, -62f);
					this.list_0.Add(this.class531_0);
					this.class531_0.int_0 = 1;
					this.class531_1 = new Class531(Class885.Load("levelbar", Enum112.flag_1), vector2_1, num + 3.5E-06f, true, new Color(252, 184, 6, (!this.bool_7 || bool_11) ? 0 : 255));
					this.class531_1.vector2_5 = new Vector2(-120f, -62f);
					this.method_8();
					this.list_0.Add(this.class531_1);
					this.class531_1.int_0 = 1;
					this.class531_0.bool_7 = true;
					this.class531_0.float_3 = 0.4f;
					this.class531_1.bool_7 = true;
					this.class531_1.float_3 = 0.7f;
					this.class531_2.bool_7 = true;
					this.color_0 = (this.class531_2.color_0 = new Color(1, 1, 1));
					this.class531_3.method_8(true);
				}
				this.method_12();
				return true;
			}
			Vector2 vector2 = this.list_0[0].vector2_0;
			bool flag = false;
			foreach (Class531 current in this.list_0)
			{
				Vector2 vector3 = vector2_1 + (current.vector2_0 - vector2);
				if (!(vector3 == current.vector2_1) || current.class26_0.Count != 0)
				{
					flag = true;
					if (this.bool_1)
					{
						if (this.bool_7 && this.class911_0.float_0 > 0f && this.class531_2.bool_3)
						{
							current.method_19(vector3, 500, Enum70.const_26);
						}
						else
						{
							List<Class746> arg_63D_0 = current.class26_0;
							if (Class861.predicate_0 == null)
							{
								Class861.predicate_0 = new Predicate<Class746>(Class861.smethod_1);
							}
							arg_63D_0.RemoveAll(Class861.predicate_0);
							current.vector2_1 = vector3;
						}
					}
					else
					{
						current.vector2_1 = vector3;
					}
					current.vector2_0 = vector3;
					if (current.int_0 == 0)
					{
						current.float_3 = (float)(this.bool_7 ? 1 : 0);
					}
				}
			}
			this.method_12();
			if (flag && this.class533_4 != null)
			{
				if (!this.class533_4.bool_3)
				{
					this.class533_4 = null;
				}
				else
				{
					this.class533_4.method_19(vector2_1 + (this.class533_4.vector2_1 - vector2), 500, Enum70.const_1);
				}
			}
			return false;
		}

		// Token: 0x060031FB RID: 12795
		// RVA: 0x00148250 File Offset: 0x00146450
		private Class731 method_11()
		{
			if (this.long_1 > 0L || this.bStatus_0 == bStatus.Playing || this.bStatus_0 == bStatus.Multiplaying || this.bStatus_0 == bStatus.Testing)
			{
				switch (this.playModes_0)
				{
				case PlayModes.Osu:
					return Class885.Load("mode-osu-small", Enum112.flag_1);
				case PlayModes.Taiko:
					return Class885.Load("mode-taiko-small", Enum112.flag_1);
				case PlayModes.CatchTheBeat:
					return Class885.Load("mode-fruits-small", Enum112.flag_1);
				case PlayModes.OsuMania:
					return Class885.Load("mode-mania-small", Enum112.flag_1);
				}
			}
			return null;
		}

		// Token: 0x060031FC RID: 12796
		// RVA: 0x001482D8 File Offset: 0x001464D8
		private void method_12()
		{
			if (this.class531_2 != null)
			{
				Color color = Class610.smethod_2(this.color_0, 0.2f);
				if (this.bool_7 && this.class911_0.float_0 > 0f && this.class531_2.bool_3)
				{
					this.class531_2.method_39(this.color_0, 300, true, Enum70.const_0);
					this.class531_3.method_39(color, 300, true, Enum70.const_0);
				}
				else
				{
					List<Class746> arg_9D_0 = this.class531_2.class26_0;
					if (Class861.predicate_1 == null)
					{
						Class861.predicate_1 = new Predicate<Class746>(Class861.smethod_2);
					}
					arg_9D_0.RemoveAll(Class861.predicate_1);
					this.class531_2.color_0 = (this.class531_2.color_1 = this.color_0);
					List<Class746> arg_EA_0 = this.class531_3.class26_0;
					if (Class861.predicate_2 == null)
					{
						Class861.predicate_2 = new Predicate<Class746>(Class861.smethod_3);
					}
					arg_EA_0.RemoveAll(Class861.predicate_2);
					this.class531_3.color_0 = (this.class531_3.color_1 = color);
				}
				this.class531_2.class746_1 = new Class746(this.color_0, new Color((byte)Math.Min(255, (int)(this.color_0.get_R() + 40)), (byte)Math.Min(255, (int)(this.color_0.get_G() + 40)), (byte)Math.Min(255, (int)(this.color_0.get_B() + 40))), 0, 100);
				if (this.int_3 > 200000)
				{
					this.class533_2.method_57(new Color(255, 255, 255, 20));
				}
				if (this.int_3 > 100000)
				{
					this.class533_2.method_57(new Color(255, 255, 255, 40));
					return;
				}
				if (this.int_3 > 50000)
				{
					this.class533_2.method_57(new Color(255, 255, 255, 60));
					return;
				}
				if (this.int_3 > 1000)
				{
					this.class533_2.method_57(new Color(255, 255, 255, 80));
					return;
				}
				if (this.int_3 > 10)
				{
					this.class533_2.method_57(new Color(255, 255, 255, 100));
					return;
				}
				if (this.int_3 > 1)
				{
					this.class533_2.method_57(new Color(244, 218, 73, 120));
					return;
				}
				this.class533_2.method_57(new Color(88, 171, 248, 120));
			}
		}

		// Token: 0x060031FD RID: 12797
		// RVA: 0x00148588 File Offset: 0x00146788
		private void method_13(object sender, EventArgs e)
		{
			this.class533_0.method_14(100, Enum70.const_0);
			this.class533_0.bool_3 = true;
			this.class533_3.method_16(100, Enum70.const_0);
			this.class531_3.method_39(Color.get_Black(), 200, false, Enum70.const_0);
		}

		// Token: 0x060031FE RID: 12798
		// RVA: 0x001485D8 File Offset: 0x001467D8
		private void method_14(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short", 1f, false);
			this.class533_0.method_16(100, Enum70.const_0);
			this.class533_3.method_14(100, Enum70.const_0);
			this.class533_3.bool_3 = true;
			this.class531_3.method_39(Color.get_White(), 200, false, Enum70.const_0);
		}

		// Token: 0x060031FF RID: 12799
		// RVA: 0x00024DCB File Offset: 0x00022FCB
		internal void method_15()
		{
			this.method_4(true);
		}

		// Token: 0x06003200 RID: 12800
		// RVA: 0x00024DD5 File Offset: 0x00022FD5
		public void method_16(bool bool_11)
		{
			this.list_0[0].bool_1 = bool_11;
		}

		// Token: 0x06003202 RID: 12802
		// RVA: 0x00024DE9 File Offset: 0x00022FE9
		private void method_17()
		{
			this.list_0 = null;
			this.class537_0 = null;
		}

		// Token: 0x06003203 RID: 12803
		// RVA: 0x00148660 File Offset: 0x00146860
		internal bool method_18(bool bool_11, bool bool_12)
		{
			if (this.bool_9 && !bool_12)
			{
				return false;
			}
			Class855 class = Class856.smethod_5(this.int_1, bool_11);
			if (class != null)
			{
				this.method_5(class.class17_0);
				return true;
			}
			return false;
		}

		// Token: 0x06003204 RID: 12804
		// RVA: 0x00024DF9 File Offset: 0x00022FF9
		[CompilerGenerated]
		private void method_19()
		{
			this.class537_0.float_2 = 74f / (float)Math.Max(this.class537_0.int_6, this.class537_0.int_5);
		}

		// Token: 0x060031E9 RID: 12777
		// RVA: 0x00146B80 File Offset: 0x00144D80
		internal Class537 method_2(Vector2 vector2_1, float float_3, float float_4)
		{
			Class861.Class862 class = new Class861.Class862();
			class.float_0 = float_4;
			bool flag = this.int_1 == Class115.class861_0.int_1;
			class.class537_0 = new Class537((this.int_1 < 0) ? null : string.Format((this.int_1 == Class115.class861_0.int_1) ? "http://a.ppy.sh/{0}" : "http://a.ppy.sh/{0}", this.int_1), "Data/a/" + this.int_1, flag ? 0 : 500, vector2_1, float_3);
			class.class537_0.method_55(new VoidDelegate(class.method_0));
			return class.class537_0;
		}

		// Token: 0x060031EA RID: 12778
		// RVA: 0x00146C34 File Offset: 0x00144E34
		public bool method_3(Class537 class537_1, float float_3)
		{
			class537_1.origins_0 = Origins.Centre;
			class537_1.method_52(string.Format((this.int_1 == Class115.class861_0.int_1) ? "http://a.ppy.sh/{0}" : "http://a.ppy.sh/{0}", this.int_1));
			class537_1.method_54("Data/a/" + this.int_1);
			class537_1.float_7 = float_3;
			return class537_1.enum69_0 == Enum69.const_0;
		}

		// Token: 0x060031F4 RID: 12788
		// RVA: 0x00146F18 File Offset: 0x00145118
		internal bool method_4(bool bool_11)
		{
			if (this.bool_5 && !bool_11)
			{
				return true;
			}
			if (this.bool_6)
			{
				return false;
			}
			if (this.Name.Length > 0)
			{
				this.bool_6 = true;
				if (this.list_0 != null)
				{
					this.class531_2.method_40(Color.get_Crimson(), 3000);
					this.class533_1.Text = this.Name;
					if (this.bool_2)
					{
						this.class533_0.Text = string.Empty;
					}
				}
				if (this.Name == Class341.class605_20)
				{
					Class809.smethod_34(Enum3.const_3, null);
				}
			}
			else
			{
				this.Name = "Guest";
				this.float_0 = 0f;
				this.int_1 = -1;
				this.enum30_0 = Enum30.flag_1;
				this.string_3 = Class41.GetString(OsuString.Options_Online_ClickToLogin);
				this.class533_1.Text = this.Name;
				this.class533_0.Text = this.string_3;
				this.class533_2.Text = string.Empty;
				this.class531_4.vmethod_7(null);
				this.method_3(this.class537_0, this.class537_0.float_7);
				this.method_8();
			}
			return true;
		}

		// Token: 0x060031F5 RID: 12789
		// RVA: 0x0014704C File Offset: 0x0014524C
		internal void method_5(Class17 class17_0)
		{
			this.int_1 = class17_0.int_1;
			this.Name = class17_0.string_0;
			this.int_4 = class17_0.int_0;
			if (!this.bool_4 || class17_0.bool_0)
			{
				this.bool_4 = class17_0.bool_0;
			}
			this.int_5 = (int)class17_0.byte_0;
			this.string_5 = Class861.string_0[(int)class17_0.byte_0];
			this.float_1 = class17_0.float_0;
			this.float_2 = class17_0.float_1;
			this.enum30_0 = class17_0.enum30_0;
			this.int_3 = class17_0.int_2;
			if (!this.bool_5)
			{
				this.playModes_0 = class17_0.playModes_0;
			}
			if (this.class537_0 != null)
			{
				this.method_3(this.class537_0, this.class537_0.float_7);
			}
			this.method_7();
			this.method_12();
			if (!this.bool_9)
			{
				Class111.smethod_61(this);
				this.bool_9 = true;
			}
		}

		// Token: 0x060031F6 RID: 12790
		// RVA: 0x0014713C File Offset: 0x0014533C
		internal void method_6(Class19 class19_0)
		{
			this.bool_5 = true;
			long num = this.long_1;
			double num2 = this.double_0;
			int num3 = this.int_3;
			long num4 = 0L;
			int num5 = 0;
			while (num4 + Class861.long_0[num5] < class19_0.long_1)
			{
				num4 += Class861.long_0[num5];
				num5++;
			}
			this.float_0 = (float)(num5 + 1) + (float)(class19_0.long_1 - num4) / (float)Class861.long_0[num5];
			this.long_1 = class19_0.long_0;
			this.double_0 = Math.Round((double)(class19_0.float_0 * 100f), 2);
			this.int_2 = class19_0.int_0;
			this.short_0 = class19_0.short_0;
			this.int_3 = class19_0.int_1;
			bool flag = this.playModes_0 != class19_0.class12_0.playModes_0;
			this.playModes_0 = class19_0.class12_0.playModes_0;
			if (this.list_0 != null && !this.bool_2 && (!this.bool_1 || this.class531_2.bool_3) && !flag)
			{
				if (this.long_1 != num)
				{
					Class533 class = new Class533(((num < this.long_1) ? "+" : "") + (this.long_1 - num).ToString("0,0", Class115.numberFormatInfo_0), 10f, this.class533_0.vector2_1 + new Vector2(this.class533_0.vmethod_11().X, 0f) / 2f, Vector2.get_Zero(), 0.98f, false, Color.get_YellowGreen(), true);
					class.method_63(true);
					class.object_0 = this;
					class.method_19(this.class533_0.vector2_1 + new Vector2(this.class533_0.vmethod_11().X + 2f, 0f), 1000, Enum70.const_1);
					class.method_16(6000, Enum70.const_0);
					this.class911_0.Add(class);
					this.class533_4 = class;
				}
				if (this.double_0 != num2)
				{
					bool flag2 = num2 < this.double_0;
					Class533 class2 = new Class533("\n" + (flag2 ? "+" : string.Empty) + string.Format("{0:n}%", Math.Round(this.double_0 - num2, 2)), 10f, this.class533_0.vector2_1 + new Vector2(this.class533_0.vmethod_11().X, 0f) / 2f, Vector2.get_Zero(), 0.98f, false, flag2 ? Color.get_YellowGreen() : Color.get_OrangeRed(), true);
					class2.method_63(true);
					class2.method_19(this.class533_0.vector2_1 + new Vector2(this.class533_0.vmethod_11().X + 2f, 0f), 1000, Enum70.const_1);
					class2.object_0 = this;
					class2.method_16(6000, Enum70.const_0);
					this.class911_0.Add(class2);
					this.class533_4 = class2;
				}
				if (this.int_3 != num3)
				{
					Class533 class3 = new Class533(((num3 > this.int_3) ? "+" : string.Empty) + (-this.int_3 + num3), 30f, this.class533_2.vector2_1, Vector2.get_Zero(), 0.976f, true, Color.get_White(), false);
					class3.method_63(true);
					class3.origins_0 = Origins.TopRight;
					class3.method_23(new Vector2(0f, -19f), 1000, Enum70.const_1);
					class3.object_0 = this;
					class3.method_16(4000, Enum70.const_0);
					this.class911_0.Add(class3);
					this.class533_4 = class3;
				}
			}
			this.string_1 = class19_0.class12_0.string_1;
			this.int_0 = class19_0.class12_0.int_0;
			this.string_2 = class19_0.class12_0.string_0;
			this.mods_0 = class19_0.class12_0.mods_0;
			this.bStatus_0 = class19_0.class12_0.bStatus_0;
			if (this.class531_4 != null && (this.class531_4.vmethod_6() == null || flag))
			{
				this.class531_4.vmethod_7(this.method_11());
			}
			switch (class19_0.class12_0.bStatus_0)
			{
			case bStatus.Afk:
				this.color_0 = new Color(10, 10, 10);
				goto IL_61E;
			case bStatus.Playing:
			case bStatus.Paused:
				this.color_0 = new Color(140, 160, 160);
				" " + this.string_1;
				goto IL_61E;
			case bStatus.Editing:
				this.color_0 = new Color(160, 60, 60);
				" " + this.string_1;
				goto IL_61E;
			case bStatus.Modding:
				this.color_0 = new Color(60, 160, 60);
				" " + this.string_1;
				goto IL_61E;
			case bStatus.Multiplayer:
			case bStatus.Lobby:
				this.color_0 = new Color(164, 108, 28);
				goto IL_61E;
			case bStatus.Watching:
				this.color_0 = new Color(60, 60, 160);
				" " + this.string_1;
				goto IL_61E;
			case bStatus.Testing:
				this.color_0 = new Color(160, 60, 160);
				" " + this.string_1;
				goto IL_61E;
			case bStatus.Submitting:
				this.color_0 = new Color(139, 238, 180);
				" " + this.string_1;
				goto IL_61E;
			case bStatus.Multiplaying:
				this.color_0 = new Color(221, 190, 0);
				" " + this.string_1;
				goto IL_61E;
			}
			this.color_0 = new Color(10, 29, 75);
			IL_61E:
			if (!this.bool_1)
			{
				this.color_0 = new Color(1, 1, 1);
			}
			string a = string.Format("{1:HH:mm} @ {3}\n{0} {4}", new object[]
			{
				this.bStatus_0,
				DateTime.UtcNow.AddHours((double)this.int_4),
				((this.int_4 >= 0) ? "+" : string.Empty) + this.int_4,
				this.string_5,
				this.string_1
			});
			bool flag3 = a != this.string_8;
			this.string_8 = a;
			if (flag3)
			{
				this.method_9();
			}
			this.bool_2 = false;
			this.method_12();
			this.method_7();
			this.bool_6 = false;
		}

		// Token: 0x060031F7 RID: 12791
		// RVA: 0x00147838 File Offset: 0x00145A38
		private void method_7()
		{
			if (!this.bool_5)
			{
				this.string_3 = string.Empty;
			}
			else
			{
				if (this.short_0 > 0)
				{
					this.string_3 = string.Format(Class115.numberFormatInfo_0, "Performance:{0}pp\nAccuracy:{1:0.00}%\n" + (this.bool_1 ? "Play Count: {2} (Lv{3:0})" : "Lv{3}"), new object[]
					{
						this.short_0.ToString("#,0", Class115.numberFormatInfo_0),
						this.double_0,
						this.int_2,
						(int)this.float_0,
						this.short_0
					});
				}
				else if (this.long_1 > 0L)
				{
					float num = (float)this.long_1;
					string str = string.Empty;
					if (num > 1E+09f)
					{
						str = "b";
						num /= 1E+09f;
					}
					else if (num > 1000000f)
					{
						str = "m";
						num /= 1000000f;
					}
					else if (num > 0f)
					{
						str = "k";
						num /= 1000f;
					}
					string text = ((num % 1f != 0f) ? num.ToString("#,0.0", Class115.numberFormatInfo_0) : num.ToString("#,0", Class115.numberFormatInfo_0)) + str;
					this.string_3 = string.Format(Class115.numberFormatInfo_0, "Score:{0}\nAccuracy:{1:0.00}%\n" + (this.bool_1 ? "Play Count: {2} (Lv{3:0})" : "Lv{3}"), new object[]
					{
						text,
						this.double_0,
						this.int_2,
						(int)this.float_0
					});
				}
				else
				{
					this.string_3 = Class41.GetString(OsuString.User_Neverplayed);
				}
				this.string_7 = ((this.int_3 == 0) ? string.Empty : ("#" + this.int_3));
			}
			if (this.list_0 != null)
			{
				this.class533_0.Text = this.string_3;
				this.class533_1.Text = this.Name;
				if (this.class533_3 != null)
				{
					this.class533_3.Text = this.string_8;
				}
				this.method_8();
				this.class533_2.Text = this.string_7;
			}
		}

		// Token: 0x060031F8 RID: 12792
		// RVA: 0x00024DA0 File Offset: 0x00022FA0
		private void method_8()
		{
			if (this.class531_1 != null)
			{
				this.class531_1.int_4 = (int)(198f * (this.float_0 - (float)((int)this.float_0)));
			}
		}

		// Token: 0x060031F9 RID: 12793
		// RVA: 0x00147A98 File Offset: 0x00145C98
		private void method_9()
		{
			if (this.bool_7 && this.class533_3 != null)
			{
				this.class533_0.method_16(100, Enum70.const_0);
				this.class533_3.method_14(100, Enum70.const_0);
				this.class533_3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 4000, Class115.int_1 + 5000, Enum70.const_0));
				this.class533_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + 4000, Class115.int_1 + 5000, Enum70.const_0));
				return;
			}
		}

		// Token: 0x06003205 RID: 12805
		// RVA: 0x0014869C File Offset: 0x0014689C
		[CompilerGenerated]
		private static void smethod_0(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
		}

		// Token: 0x06003206 RID: 12806
		// RVA: 0x0001925A File Offset: 0x0001745A
		[CompilerGenerated]
		private static bool smethod_1(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Movement;
		}

		// Token: 0x06003207 RID: 12807
		// RVA: 0x00018A4E File Offset: 0x00016C4E
		[CompilerGenerated]
		private static bool smethod_2(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Colour;
		}

		// Token: 0x06003208 RID: 12808
		// RVA: 0x00018A4E File Offset: 0x00016C4E
		[CompilerGenerated]
		private static bool smethod_3(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Colour;
		}
	}
}
