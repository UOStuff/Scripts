
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
	public class waterfallpatiostoneAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4944, -4, -2, 0}, {4945, -4, -3, 0}, {4946, -4, -2, 0}// 1	2	3	
			, {4947, -3, -2, 0}, {4943, -5, -2, 0}, {4952, -4, -2, 12}// 4	5	6	
			, {4951, -5, -2, 12}, {4953, -4, -3, 12}, {4943, -3, -1, 20}// 7	8	9	
			, {4944, -2, -1, 20}, {4946, -2, 0, 40}, {4947, -1, 0, 40}// 10	11	12	
			, {13591, -2, -3, 10}, {13591, -1, -3, 0}, {13591, 0, -2, 22}// 13	14	15	
			, {13591, -2, -3, 0}, {13585, -1, -2, 28}, {13585, 1, -1, 38}// 16	17	18	
			, {13597, -2, -2, 0}, {13597, -1, -2, 0}, {13603, -2, -1, 0}// 19	20	21	
			, {13603, -1, -1, 0}, {13422, -3, -2, 0}, {13422, -3, -1, 0}// 22	23	24	
			, {4943, 0, -2, 0}, {4944, 1, -2, 0}, {4945, 1, -3, 0}// 25	26	27	
			, {4946, 1, -1, 20}, {4947, 2, -1, 20}, {4951, 1, -2, 35}// 28	29	30	
			, {4952, 1, -2, 35}, {4953, 2, -3, 35}, {4948, 1, -2, 20}// 31	32	33	
			, {4952, 2, -2, 35}, {4948, 2, -2, 20}, {13422, 0, -2, 0}// 34	35	36	
			, {13422, 0, -1, 0}, {13422, -3, 0, 0}, {13422, -3, 1, 0}// 37	38	39	
			, {13422, -3, 2, 0}, {13422, -2, 0, 0}, {13422, -2, 1, 0}// 40	41	42	
			, {13422, -2, 2, 0}, {13422, -1, 0, 0}, {13422, -1, 1, 0}// 43	44	45	
			, {13422, -1, 2, 0}, {13422, 0, 0, 0}, {13422, 0, 1, 0}// 46	47	48	
			, {13422, 0, 2, 0}, {13484, -2, 1, 1}, {13485, 0, 0, 1}// 49	50	51	
			, {8114, -3, 0, 1}, {8114, -1, 0, 1}, {6046, 1, -2, 0}// 52	53	54	
			, {6046, 1, -1, 0}, {6046, 1, 0, 0}, {6046, 1, 1, 0}// 55	56	57	
			, {6046, 1, 2, 0}, {6055, 1, 3, 0}, {6052, -4, -1, 0}// 58	59	60	
			, {6052, -4, 0, 0}, {6052, -4, 1, 0}, {6052, -4, 2, 0}// 61	62	63	
			, {6056, -4, 3, 0}, {6050, -3, 3, 0}, {6050, -2, 3, 0}// 64	65	66	
			, {6050, -1, 3, 0}, {6050, 0, 3, 0}, {1313, -3, -8, 50}// 67	68	77	
			, {1313, -3, -7, 50}, {1313, -3, -6, 50}, {1313, -3, -5, 50}// 78	79	80	
			, {1313, -3, -4, 50}, {1313, -3, -3, 50}, {1313, -3, -2, 50}// 81	82	83	
			, {1313, -2, -8, 50}, {1313, -2, -7, 50}, {1313, -2, -6, 50}// 84	85	86	
			, {1313, -2, -5, 50}, {1313, -2, -4, 50}, {1313, -2, -3, 50}// 87	88	89	
			, {1313, -2, -2, 50}, {1313, -1, -8, 50}, {1313, -1, -7, 50}// 90	91	92	
			, {1313, -1, -6, 50}, {1313, -1, -5, 50}, {1313, -1, -4, 50}// 93	94	95	
			, {1313, -1, -3, 50}, {1313, -1, -2, 50}, {1313, 0, -8, 50}// 96	97	98	
			, {1313, 0, -7, 50}, {1313, 0, -6, 50}, {1313, 0, -5, 50}// 99	100	101	
			, {1313, 0, -4, 50}, {1313, 0, -3, 50}, {1313, 0, -2, 50}// 102	103	104	
			, {1313, 1, -8, 50}, {1313, 1, -7, 50}, {1313, 1, -6, 50}// 105	106	107	
			, {1313, 1, -5, 50}, {1313, 1, -4, 50}, {1313, 1, -3, 50}// 108	109	110	
			, {1313, 1, -2, 50}, {1313, 2, -8, 50}, {1313, 2, -7, 50}// 111	112	113	
			, {1313, 2, -6, 50}, {1313, 2, -5, 50}, {1313, 2, -4, 50}// 114	115	116	
			, {1313, 2, -3, 50}, {1313, 2, -2, 50}, {489, -3, -9, 50}// 117	118	119	
			, {489, -2, -9, 50}, {489, -1, -9, 50}, {489, 0, -9, 50}// 120	121	122	
			, {489, 1, -9, 50}, {489, 2, -9, 50}, {491, -4, -9, 50}// 123	124	125	
			, {490, -4, -8, 50}, {490, -4, -7, 50}, {490, -4, -6, 50}// 126	127	128	
			, {490, -4, -5, 50}, {490, -4, -4, 50}, {490, -4, -3, 50}// 129	130	131	
			, {490, -4, -2, 50}, {489, -2, -2, 50}, {489, -1, -2, 50}// 132	133	134	
			, {489, 0, -2, 50}, {489, 1, -2, 50}, {489, 2, -2, 50}// 135	136	137	
			, {1313, 3, -8, 50}, {1313, 3, -7, 50}, {1313, 3, -6, 50}// 141	142	143	
			, {1313, 3, -5, 50}, {1313, 3, -4, 50}, {1313, 3, -3, 50}// 144	145	146	
			, {1313, 3, -2, 50}, {1313, 4, -8, 50}, {1313, 4, -7, 50}// 147	148	149	
			, {1313, 4, -6, 50}, {1313, 4, -5, 50}, {1313, 4, -4, 50}// 150	151	152	
			, {1313, 4, -3, 50}, {1313, 4, -2, 50}, {1313, 5, -8, 50}// 153	154	155	
			, {1313, 5, -7, 50}, {1313, 5, -6, 50}, {1313, 5, -5, 50}// 156	157	158	
			, {1313, 5, -4, 50}, {1313, 5, -3, 50}, {1313, 5, -2, 50}// 159	160	161	
			, {488, 5, -2, 50}, {489, 3, -9, 50}, {489, 4, -9, 50}// 162	163	164	
			, {489, 5, -9, 50}, {490, 5, -8, 50}, {490, 5, -7, 50}// 165	166	167	
			, {490, 5, -6, 50}, {490, 5, -5, 50}, {490, 5, -4, 50}// 168	169	170	
			, {490, 5, -3, 50}, {489, 3, -2, 50}, {489, 4, -2, 50}// 171	172	173	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new waterfallpatiostoneAddonDeed();
			}
		}

		[ Constructable ]
		public waterfallpatiostoneAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1007, -3, -1, 45, 747, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1007, -3, 0, 41, 747, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1007, -3, 1, 37, 747, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1007, -3, 2, 33, 747, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1007, -3, 3, 29, 747, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1007, -3, 4, 25, 747, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1007, -3, 5, 21, 747, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1007, -3, 6, 16, 747, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 1007, -3, 7, 11, 747, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1007, -3, 8, 7, 747, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 1007, -3, 9, 2, 747, -1, "", 1);// 140

		}

		public waterfallpatiostoneAddon( Serial serial ) : base( serial )
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

	public class waterfallpatiostoneAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new waterfallpatiostoneAddon();
			}
		}

		[Constructable]
		public waterfallpatiostoneAddonDeed()
		{
			Name = "waterfallpatiostone";
		}

		public waterfallpatiostoneAddonDeed( Serial serial ) : base( serial )
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