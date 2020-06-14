
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
	public class StonePatioWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2938, 0, 1, 0}, {1256, -2, -1, 0}, {1256, 2, 5, 0}// 1	2	3	
			, {1822, -6, 3, 3}, {2938, 1, 1, 0}, {95, 1, 5, 0}// 4	5	6	
			, {1256, 2, 3, 0}, {2459, -6, 0, 11}, {95, 2, 5, 0}// 7	8	9	
			, {96, -7, -2, 0}, {95, 3, -4, 0}, {1256, -1, 1, 0}// 10	11	12	
			, {5111, -5, 3, 9}, {2913, 2, 1, 0}, {2933, 1, 2, 0}// 13	14	15	
			, {2933, 0, 2, 0}, {1256, 0, 4, 0}, {1256, -1, 3, 0}// 16	17	18	
			, {1256, 2, 4, 0}, {1256, -3, 3, 0}, {1256, -3, 2, 0}// 19	20	22	
			, {1256, 0, -1, 0}, {1256, -3, 5, 0}, {95, -1, 5, 0}// 23	24	25	
			, {2934, 1, -1, 0}, {1256, -3, 1, 0}, {1256, -2, 1, 0}// 26	27	28	
			, {1822, -5, 0, 0}, {1256, 4, -2, 0}, {1256, 1, 1, 0}// 29	30	31	
			, {6869, 1, 1, 29}, {1822, -5, 3, 0}, {95, -5, 4, 0}// 32	33	34	
			, {2938, 1, 0, 0}, {1256, -2, 5, 0}, {1256, -4, -1, 0}// 35	36	37	
			, {3207, 1, 3, 35}, {96, -7, 2, 0}, {1822, -6, 0, 2}// 38	39	41	
			, {4554, 0, 3, 0}, {1256, -1, -3, 0}, {96, -7, 1, 0}// 42	43	44	
			, {1256, -2, 0, 0}, {3207, 3, 1, 35}, {1256, -3, -2, 0}// 45	46	47	
			, {1256, -2, 2, 0}, {1256, 0, 5, 0}, {1256, 0, 2, 0}// 48	49	50	
			, {96, -5, 5, 0}, {1256, 0, -2, 0}, {1256, -2, 3, 0}// 51	52	53	
			, {1256, 3, 1, 0}, {1256, -2, 4, 0}, {95, -1, -4, 0}// 54	55	56	
			, {3245, 2, -1, 0}, {4554, 1, 3, 0}, {7700, -4, 4, 0}// 57	58	59	
			, {2449, -5, 3, 7}, {1256, 2, -2, 0}, {95, 0, -4, 0}// 60	61	62	
			, {1822, -6, 2, 4}, {1822, -5, 3, 2}, {1256, -4, 3, 0}// 63	64	65	
			, {1256, 4, 4, 0}, {1822, -6, 1, 6}, {6467, -5, 0, 4}// 66	67	68	
			, {5628, -6, 2, 9}, {1256, 1, 5, 0}, {95, -3, 5, 0}// 69	71	72	
			, {1256, 0, 3, 0}, {95, -2, -4, 0}, {1256, 3, 0, 0}// 73	74	75	
			, {96, -7, 0, 0}, {1256, -4, 0, 0}, {5637, -6, -2, 7}// 76	77	78	
			, {1256, 3, 3, 0}, {5628, -6, 2, 9}, {1256, 1, -2, 0}// 79	80	81	
			, {96, -5, -3, 0}, {1256, 3, -3, 0}, {1256, 2, 0, 0}// 82	83	84	
			, {1256, -4, 5, 0}, {1256, 3, -1, 0}, {1256, -4, 1, 0}// 86	87	88	
			, {1256, 1, 3, 0}, {1256, 3, 2, 0}, {1822, -6, 3, 0}// 89	90	93	
			, {3245, 2, 3, 0}, {1822, -6, -1, 4}, {1256, 1, 4, 0}// 94	95	96	
			, {3530, -5, -1, 6}, {7703, -5, 2, 7}, {1822, -5, 2, 0}// 97	98	99	
			, {1256, 2, 2, 0}, {7138, -5, 4, 0}, {95, 4, -4, 0}// 100	101	102	
			, {98, -5, -4, 0}, {1256, -3, 0, 0}, {7696, -4, -3, 5}// 103	104	105	
			, {1822, -6, 1, 2}, {1822, -6, -1, 4}, {1822, -6, 0, 2}// 106	107	108	
			, {1822, -6, 3, 0}, {1822, -6, 0, 6}, {1256, 1, -3, 0}// 110	112	113	
			, {1256, 1, -1, 0}, {1256, -1, -1, 0}, {1256, -2, -3, 0}// 114	115	116	
			, {1256, 3, 5, 0}, {1822, -6, 1, 6}, {1256, 1, 0, 0}// 117	119	120	
			, {3530, -5, 1, 6}, {5634, -6, 1, 11}, {1256, 0, 0, 0}// 121	122	123	
			, {1256, -3, -3, 0}, {2421, -5, -1, 6}, {95, 1, -4, 0}// 124	125	126	
			, {3530, -5, 2, 6}, {5634, -6, 1, 11}, {1822, -6, 0, 6}// 127	129	130	
			, {1822, -5, 0, 2}, {95, 2, -4, 0}, {1822, -6, 2, 4}// 131	132	133	
			, {1256, -1, 0, 0}, {95, 0, 5, 0}, {1256, 1, 2, 0}// 134	135	136	
			, {95, -2, 5, 0}, {95, -5, -3, 0}, {1256, 4, -3, 0}// 137	138	139	
			, {1256, 4, 0, 0}, {1822, -6, -2, 3}, {1822, -6, 1, 2}// 140	142	144	
			, {1256, -1, -2, 0}, {1822, -5, -1, 0}, {1256, 4, 5, 0}// 145	146	147	
			, {2518, -6, 3, 8}, {96, -7, 3, 0}, {95, -4, -4, 0}// 148	149	150	
			, {95, 4, 5, 0}, {1256, 2, -1, 0}, {95, -3, -4, 0}// 152	153	154	
			, {1822, -5, 1, 0}, {4329, -5, -2, 7}, {1256, -4, -3, 0}// 155	156	157	
			, {1256, -4, 2, 0}, {1256, -3, -1, 0}, {1822, -5, -2, 2}// 158	159	160	
			, {1256, -4, 4, 0}, {1256, -1, 2, 0}, {95, 3, 5, 0}// 161	162	163	
			, {1256, 4, -1, 0}, {96, -7, -1, 0}, {7703, -5, 1, 7}// 164	165	166	
			, {96, -7, 4, 0}, {1256, 3, 4, 0}, {1256, 4, 1, 0}// 167	168	170	
			, {1256, -2, -2, 0}, {1256, 4, 2, 0}, {1256, 0, 1, 0}// 171	172	173	
			, {5637, -6, -2, 7}, {5625, -6, -1, 9}, {95, -4, 5, 0}// 174	175	176	
			, {1256, 2, 1, 0}, {2416, -5, -1, 14}, {95, -6, 4, 0}// 177	178	179	
			, {1256, -3, 4, 0}, {1256, 2, -3, 0}, {1256, 3, -2, 0}// 180	181	182	
			, {1256, 0, -3, 0}, {1822, -5, -2, 0}, {1822, -6, 3, 3}// 183	184	185	
			, {1256, -4, -2, 0}, {98, -7, -3, 0}, {2912, 2, -1, 0}// 186	188	189	
			, {1256, 4, 3, 0}, {1256, -1, 5, 0}, {5625, -6, -1, 9}// 190	191	192	
			, {1256, -1, 4, 0}, {95, -6, -3, 0}, {1822, -6, -2, 3}// 193	194	195	
			, {2911, -1, 2, 0}, {2938, 0, 0, 0}, {3207, 1, 1, 35}// 196	197	198	
			, {3245, -1, 3, 0}, {2912, -1, -1, 0}, {2913, -1, 1, 0}// 199	200	201	
			, {2913, 2, 0, 0}, {9354, 0, 0, 1}, {2911, 2, 2, 0}// 202	203	204	
			, {2934, 0, -1, 0}, {3294, 1, 1, 12}, {2913, -1, 0, 0}// 205	206	207	
			, {96, 7, 3, 0}, {1256, 5, -3, 0}, {1256, 5, 4, 0}// 208	209	210	
			, {1256, 7, 0, 0}, {1256, 5, 5, 0}, {1256, 6, 2, 0}// 211	212	213	
			, {1256, 6, -1, 0}, {1256, 6, 5, 0}, {1256, 5, 1, 0}// 214	215	216	
			, {1256, 6, 0, 0}, {1256, 7, 4, 0}, {95, 6, -4, 0}// 217	218	219	
			, {96, 7, 5, 0}, {1256, 5, -2, 0}, {1256, 5, 2, 0}// 220	221	222	
			, {1256, 7, -1, 0}, {1256, 7, 1, 0}, {7697, 6, 4, 0}// 223	224	225	
			, {1256, 7, 3, 0}, {96, 7, 2, 0}, {95, 5, -4, 0}// 226	227	228	
			, {96, 7, -1, 0}, {1256, 6, 1, 0}, {95, 5, 5, 0}// 229	230	231	
			, {95, 6, 5, 0}, {96, 7, -2, 0}, {1256, 6, -2, 0}// 232	233	234	
			, {96, 7, -3, 0}, {96, 7, 5, 0}, {1256, 7, -3, 0}// 235	236	237	
			, {95, 7, 5, 0}, {1256, 6, 3, 0}, {1256, 7, 5, 0}// 238	239	240	
			, {1256, 5, 0, 0}, {1256, 7, -2, 0}, {1256, 6, -3, 0}// 241	242	243	
			, {7695, 6, -3, 0}, {1256, 5, 3, 0}, {95, 7, -4, 0}// 244	245	246	
			, {1256, 7, 2, 0}, {1256, 5, -1, 0}, {96, 7, 4, 0}// 247	248	249	
			, {1256, 6, 4, 0}// 250	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new StonePatioWEAddonDeed();
			}
		}

		[ Constructable ]
		public StonePatioWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4846, -5, -1, 5, 0, 1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 6467, -5, 0, 4, 0, -1, "Imported Spices", 1);// 40
			AddComplexComponent( (BaseAddon) this, 3530, -5, -1, 6, 1, -1, "Grill", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2518, -6, 3, 8, 0, -1, "Marinade", 1);// 85
			AddComplexComponent( (BaseAddon) this, 4846, -5, 1, 5, 0, 1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 4846, -5, 1, 5, 0, 0, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 2459, -6, 0, 11, 0, -1, "Cooking Wine", 1);// 109
			AddComplexComponent( (BaseAddon) this, 4846, -5, 2, 5, 0, 1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 3530, -5, 2, 6, 1, -1, "Grill", 1);// 118
			AddComplexComponent( (BaseAddon) this, 7703, -5, 2, 7, 0, -1, "Grilled Salmon", 1);// 128
			AddComplexComponent( (BaseAddon) this, 7138, -5, 4, 0, 0, -1, "Mesquite Logs", 1);// 141
			AddComplexComponent( (BaseAddon) this, 4846, -5, -1, 5, 0, 0, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 3530, -5, 1, 6, 1, -1, "Grill", 1);// 151
			AddComplexComponent( (BaseAddon) this, 4846, -5, 2, 5, 0, 0, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 7703, -5, 1, 7, 0, -1, "Grilled Salmon", 1);// 187

		}

		public StonePatioWEAddon( Serial serial ) : base( serial )
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

	public class StonePatioWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new StonePatioWEAddon();
			}
		}

		[Constructable]
		public StonePatioWEAddonDeed()
		{
			Name = "StonePatioWE";
		}

		public StonePatioWEAddonDeed( Serial serial ) : base( serial )
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