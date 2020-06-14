
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class watchtower1Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {12790, 1, -2, 13}, {12, 0, -3, 11}, {12790, 2, -2, 13}// 1	2	3	
			, {9946, 1, -3, 58}, {9947, 4, -3, 49}, {17, 4, -2, 29}// 4	5	6	
			, {9947, 3, -2, 37}, {12, 4, -3, 11}, {1848, 1, -2, 13}// 7	8	9	
			, {9, 4, -3, 45}, {9947, 4, -2, 48}, {1208, 4, -2, 29}// 10	11	12	
			, {18, 1, -4, 29}, {1848, 1, -2, 18}, {17, -2, -3, 29}// 13	14	15	
			, {9, -1, -3, 29}, {18, -1, -4, 29}, {18, 2, -4, 29}// 16	17	18	
			, {1848, 0, -2, 13}, {2322, 6, -2, 13}, {9947, 2, -3, 57}// 19	20	21	
			, {9947, 2, -2, 57}, {1208, 3, -3, 29}, {1208, 1, -3, 29}// 22	23	24	
			, {1850, 1, -2, 21}, {1208, -1, -2, 29}, {17, -2, -2, 29}// 25	26	27	
			, {9, -1, -3, 45}, {1208, 2, -2, 20}, {9948, 0, -3, 55}// 28	29	30	
			, {1850, 2, -2, 18}, {1208, -1, -3, 29}, {9948, -1, -2, 53}// 31	32	33	
			, {12790, 3, -2, 13}, {1208, 0, -3, 29}, {9948, 0, -2, 56}// 35	36	37	
			, {9947, 3, -3, 53}, {1208, 2, -3, 29}, {12790, 0, -2, 13}// 38	39	40	
			, {9, 4, -3, 13}, {1848, 0, -2, 18}, {1208, 4, -3, 29}// 41	42	43	
			, {12, 2, -3, 12}, {9948, -1, -3, 52}, {2321, 6, -2, 13}// 44	45	46	
			, {18, 3, -4, 29}, {1850, 3, -2, 13}, {18, 0, -4, 29}// 47	48	49	
			, {12790, 4, -2, 13}, {7679, 6, -2, 13}, {9, -1, -3, 13}// 50	51	52	
			, {9947, 3, -2, 53}, {18, 4, -4, 29}, {2324, 5, -2, 13}// 53	54	55	
			, {12, 1, -3, 11}, {9, 4, -3, 29}, {9948, -2, -3, 49}// 56	57	58	
			, {9948, -2, -2, 50}, {9946, 1, -2, 58}, {1850, 0, -2, 24}// 59	60	61	
			, {1848, 0, -2, 21}, {1848, 2, -2, 13}, {17, 4, -3, 29}// 62	63	64	
			, {6021, 5, -1, 13}, {9, -1, 2, 13}, {18, 0, 2, 29}// 65	66	67	
			, {1208, 1, 2, 29}, {1339, -5, 1, 0}, {12790, 0, -1, 13}// 68	69	70	
			, {9948, -1, 1, 53}, {1208, 4, 1, 29}, {1208, 3, 2, 29}// 71	72	73	
			, {9948, -2, 0, 51}, {1339, -5, 3, 0}, {1339, -5, -1, 0}// 74	75	76	
			, {1208, 2, 1, 29}, {17, -2, 0, 29}, {17, -2, -1, 29}// 77	78	79	
			, {3311, 5, 2, 23}, {12790, 0, 2, 13}, {1339, -2, 4, 0}// 81	83	84	
			, {1208, -1, 0, 29}, {9946, 1, 0, 58}, {12790, 0, 0, 13}// 85	86	87	
			, {9, 4, 2, 45}, {9946, 1, 2, 58}, {1339, -4, 3, 0}// 88	89	90	
			, {9, -1, 2, 29}, {1339, -4, 2, 0}, {6021, 5, 0, 13}// 91	92	93	
			, {9948, -2, 2, 51}, {12790, 4, -1, 13}, {6020, 3, 3, 13}// 94	95	96	
			, {1208, 0, 0, 29}, {1339, -4, 0, 0}, {12790, 3, -1, 13}// 97	98	99	
			, {1339, -4, 4, 0}, {18, 3, 2, 29}, {1339, -2, 3, 0}// 100	101	102	
			, {1339, -5, 0, 0}, {1339, -3, 2, 0}, {12790, 1, 1, 13}// 103	104	105	
			, {1339, -2, 0, 0}, {1339, -5, 2, 0}, {1339, -2, 2, 0}// 106	107	108	
			, {1339, -5, 4, 0}, {1339, -4, -1, 0}, {12790, 3, 2, 13}// 109	110	111	
			, {1339, -3, 4, 0}, {1339, -3, 0, 0}, {1339, -3, -1, 0}// 112	113	114	
			, {1339, -3, 3, 0}, {1339, -2, 1, 0}, {12790, 1, -1, 13}// 115	116	117	
			, {1339, -2, -1, 0}, {1339, -4, 1, 0}, {1339, -3, 1, 0}// 118	119	120	
			, {9947, 4, 2, 49}, {12790, 2, 2, 13}, {9948, 0, 0, 57}// 121	122	123	
			, {17, 4, 1, 13}, {12790, 3, 1, 13}, {1208, 2, 2, 29}// 124	125	126	
			, {1208, 3, 0, 29}, {9, 4, 2, 29}, {6018, 0, 2, 13}// 127	128	129	
			, {12790, 4, 0, 13}, {1208, -1, 2, 29}, {3312, 5, 1, 13}// 130	131	132	
			, {9, -1, 2, 45}, {9948, -1, -1, 53}, {9948, -2, -1, 51}// 133	134	135	
			, {1208, 0, 1, 29}, {1208, 0, -1, 29}, {18, 2, 2, 29}// 136	137	138	
			, {18, 3, 2, 13}, {9948, -1, 0, 53}, {18, 0, 2, 13}// 139	140	141	
			, {18, 1, 2, 13}, {17, 4, 0, 29}, {17, 4, -1, 13}// 142	143	144	
			, {17, 4, 1, 29}, {17, -1, -1, 13}, {3307, 4, 3, 13}// 145	146	147	
			, {9947, 2, 0, 57}, {1208, 2, 0, 29}, {9947, 3, -1, 37}// 148	149	150	
			, {17, 4, -1, 29}, {1208, 2, -1, 29}, {9946, 1, 1, 58}// 151	152	153	
			, {1208, 4, 0, 29}, {12790, 4, 2, 13}, {12790, 3, 0, 13}// 154	155	156	
			, {9948, -1, 2, 53}, {3307, 0, 3, 19}, {9946, 1, -1, 58}// 157	158	159	
			, {9947, 3, 2, 54}, {9947, 4, 1, 49}, {1208, 0, 2, 29}// 160	161	162	
			, {1208, 4, 2, 29}, {3311, 5, 2, 13}, {17, 4, 0, 13}// 163	164	165	
			, {9948, 0, 2, 55}, {12790, 1, 0, 13}, {2602, 2, 1, 13}// 166	167	168	
			, {18, 4, 2, 13}, {9947, 2, -1, 57}, {1208, 1, -1, 29}// 169	170	171	
			, {17, -1, 1, 13}, {9947, 2, 2, 57}, {18, 1, 2, 29}// 172	173	174	
			, {1208, 1, 0, 29}, {16, 4, 2, 29}, {12790, 4, 1, 13}// 175	176	177	
			, {12790, 2, -1, 13}, {12790, 0, 1, 13}, {1208, 4, -1, 29}// 178	179	180	
			, {18, -1, 2, 29}, {1208, 1, 1, 29}, {6020, 0, 3, 13}// 181	182	183	
			, {12790, 2, 0, 13}, {6020, 4, 3, 13}, {6020, 1, 3, 13}// 184	185	186	
			, {9947, 3, -1, 53}, {9947, 3, 0, 53}, {9947, 3, 1, 54}// 187	188	189	
			, {9948, -2, 1, 51}, {18, 2, 2, 13}, {7679, 5, -1, 13}// 190	191	192	
			, {9948, 0, 1, 56}, {3310, 2, 3, 13}, {1208, 3, 1, 29}// 193	194	195	
			, {9, 4, 2, 13}, {9947, 2, 1, 57}, {1208, -1, -1, 29}// 196	197	198	
			, {17, -2, 1, 29}, {17, -1, 0, 13}, {17, 4, 2, 13}// 199	200	201	
			, {3309, 3, 3, 13}, {2602, 0, 1, 13}, {9948, 0, -1, 57}// 202	203	204	
			, {17, -2, 2, 29}, {17, -1, 2, 13}, {3307, 0, 3, 13}// 205	206	207	
			, {12790, 1, 2, 13}, {1208, -1, 1, 29}, {12790, 2, 1, 13}// 208	209	210	
			, {3308, 1, 3, 13}// 211	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new watchtower1AddonDeed();
			}
		}

		[ Constructable ]
		public watchtower1Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 14, 3, -3, 11, 0, 1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 4012, 1, 1, 13, 0, 1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 3555, 1, 1, 15, 0, 1, "", 1);// 82

		}

		public watchtower1Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class watchtower1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new watchtower1Addon();
			}
		}

		[Constructable]
		public watchtower1AddonDeed()
		{
			Name = "watchtower1";
		}

		public watchtower1AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}