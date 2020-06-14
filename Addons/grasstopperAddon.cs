
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
	public class grasstopperAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6013, -8, -7, 0}, {6013, -4, -7, 0}, {6013, -5, -7, 0}// 1	2	3	
			, {6013, -3, -7, 0}, {6013, -4, -8, 0}, {6013, -3, -8, 0}// 4	5	6	
			, {6013, -7, -7, 0}, {6013, -5, -8, 0}, {6013, -1, -8, 0}// 7	8	9	
			, {6013, -2, -7, 0}, {6013, -2, -8, 0}, {6013, -6, -7, 0}// 10	11	12	
			, {6013, -7, -8, 0}, {6013, -8, -8, 0}, {6013, -6, -8, 0}// 13	14	15	
			, {6013, -1, -7, 0}, {6013, 0, 0, 0}, {6013, 1, 1, 0}// 16	17	18	
			, {6013, -1, 5, 0}, {6013, 0, 8, 0}, {6013, -1, 6, 0}// 19	20	21	
			, {6013, -6, 8, 0}, {6013, 1, 2, 0}, {6013, -1, 4, 0}// 22	23	24	
			, {6013, -1, -6, 0}, {6013, -4, -3, 0}, {6013, -1, 3, 0}// 25	26	27	
			, {6013, -5, 0, 0}, {6013, -7, 3, 0}, {6013, -8, 1, 0}// 28	29	30	
			, {6013, -2, -4, 0}, {6013, -7, -5, 0}, {6013, -8, 6, 0}// 31	32	33	
			, {6013, -3, 7, 0}, {6013, -7, -2, 0}, {6013, -4, -4, 0}// 34	35	36	
			, {6013, -7, -3, 0}, {6013, -7, 5, 0}, {6013, -8, -6, 0}// 37	38	39	
			, {6013, -1, -4, 0}, {6013, -7, 4, 0}, {6013, -8, -4, 0}// 40	41	42	
			, {6013, -8, 8, 0}, {6013, -8, 4, 0}, {6013, -8, 5, 0}// 43	44	45	
			, {6013, -6, -2, 0}, {6013, -6, 2, 0}, {6013, -6, 4, 0}// 46	47	48	
			, {6013, -8, -2, 0}, {6013, -8, -3, 0}, {6013, -8, 2, 0}// 49	50	51	
			, {6013, -7, 6, 0}, {6013, -7, 8, 0}, {6013, -5, -1, 0}// 52	53	54	
			, {6013, -5, 3, 0}, {6013, -5, 8, 0}, {6013, -5, 5, 0}// 55	56	57	
			, {6013, -4, -2, 0}, {6013, -4, 3, 0}, {6013, -4, 4, 0}// 58	59	60	
			, {6013, -4, 5, 0}, {6013, -4, 0, 0}, {6013, -4, 7, 0}// 61	62	63	
			, {6013, -6, 6, 0}, {6013, -5, -6, 0}, {6013, -5, -2, 0}// 64	65	66	
			, {6013, -3, 0, 0}, {6013, -3, 4, 0}, {6013, -6, 5, 0}// 67	68	69	
			, {6013, -3, -2, 0}, {6013, -3, -3, 0}, {6013, -3, 6, 0}// 70	71	72	
			, {6013, -5, 7, 0}, {6013, -5, 6, 0}, {6013, -2, -5, 0}// 73	74	75	
			, {6013, -3, -5, 0}, {6013, -3, -6, 0}, {6013, -3, -1, 0}// 76	77	78	
			, {6013, -2, -2, 0}, {6013, -2, 1, 0}, {6013, -4, -6, 0}// 79	80	81	
			, {6013, -4, -1, 0}, {6013, -4, -5, 0}, {6013, -3, -4, 0}// 82	83	84	
			, {6013, -4, 8, 0}, {6013, -2, 6, 0}, {6013, -3, 3, 0}// 85	86	87	
			, {6013, -3, 2, 0}, {6013, -3, 5, 0}, {6013, -3, 1, 0}// 88	89	90	
			, {6013, -2, -6, 0}, {6013, -2, 3, 0}, {6013, -2, 2, 0}// 91	92	93	
			, {6013, -2, 5, 0}, {6013, -2, -1, 0}, {6013, -6, 0, 0}// 94	95	96	
			, {6013, -6, -1, 0}, {6013, -6, 3, 0}, {6013, -2, 0, 0}// 97	98	99	
			, {6013, -4, 2, 0}, {6013, -4, 1, 0}, {6013, -4, 6, 0}// 100	101	102	
			, {6013, -6, 7, 0}, {6013, -6, -6, 0}, {6013, -7, -6, 0}// 103	104	105	
			, {6013, -2, 4, 0}, {6013, -5, -5, 0}, {6013, -5, -4, 0}// 106	107	108	
			, {6013, -5, -3, 0}, {6013, -7, 7, 0}, {6013, 0, 6, 0}// 109	110	111	
			, {6013, -1, 1, 0}, {6013, -8, -5, 0}, {6013, -5, 1, 0}// 112	113	114	
			, {6013, -8, 0, 0}, {6013, -5, 2, 0}, {6013, -3, 8, 0}// 115	116	117	
			, {6013, -8, -1, 0}, {6013, -2, 7, 0}, {6013, -2, -3, 0}// 118	119	120	
			, {6013, -6, 1, 0}, {6013, -8, 3, 0}, {6013, -8, 7, 0}// 121	122	123	
			, {6013, -6, -3, 0}, {6013, -2, 8, 0}, {6013, -5, 4, 0}// 124	125	126	
			, {6013, -7, -4, 0}, {6013, -6, -4, 0}, {6013, -6, -5, 0}// 127	128	129	
			, {6013, -7, -1, 0}, {6013, 0, 4, 0}, {6013, 0, 3, 0}// 130	131	132	
			, {6013, 1, 8, 0}, {6013, 0, 5, 0}, {6013, 1, 7, 0}// 133	134	135	
			, {6013, 0, 1, 0}, {6013, -1, 0, 0}, {6013, 0, 2, 0}// 136	137	138	
			, {6013, -1, -5, 0}, {6013, -1, -3, 0}, {6013, -1, -1, 0}// 139	140	141	
			, {6013, 1, 3, 0}, {6013, 1, 4, 0}, {6013, -1, 7, 0}// 142	143	144	
			, {6013, -1, 2, 0}, {6013, -1, 8, 0}, {6013, 1, 5, 0}// 145	146	147	
			, {6013, 1, 6, 0}, {6013, -7, 0, 0}, {6013, -7, 2, 0}// 148	149	150	
			, {6013, -1, -2, 0}, {6013, 0, 7, 0}, {6013, 1, 0, 0}// 151	152	153	
			, {6013, -7, 1, 0}, {6013, 6, 4, 0}, {6013, 3, 5, 0}// 154	155	156	
			, {6013, 8, 4, 0}, {6013, 7, 1, 0}, {6013, 6, 2, 0}// 157	158	159	
			, {6013, 8, 2, 0}, {6013, 5, 5, 0}, {6013, 2, 3, 0}// 160	161	162	
			, {6013, 4, 8, 0}, {6013, 4, 3, 0}, {6013, 2, 1, 0}// 163	164	165	
			, {6013, 4, 0, 0}, {6013, 4, 5, 0}, {6013, 3, 6, 0}// 166	167	168	
			, {6013, 4, 7, 0}, {6013, 6, 0, 0}, {6013, 6, 1, 0}// 169	170	171	
			, {6013, 4, 6, 0}, {6013, 2, 4, 0}, {6013, 5, 0, 0}// 172	173	174	
			, {6013, 2, 8, 0}, {6013, 5, 7, 0}, {6013, 7, 7, 0}// 175	176	177	
			, {6013, 5, 2, 0}, {6013, 8, 5, 0}, {6013, 7, 0, 0}// 178	179	180	
			, {6013, 7, 4, 0}, {6013, 7, 3, 0}, {6013, 8, 1, 0}// 181	182	183	
			, {6013, 7, 2, 0}, {6013, 8, 8, 0}, {6013, 8, 6, 0}// 184	185	186	
			, {6013, 8, 7, 0}, {6013, 8, 3, 0}, {6013, 2, 7, 0}// 187	188	189	
			, {6013, 6, 8, 0}, {6013, 8, 0, 0}, {6013, 6, 3, 0}// 190	191	192	
			, {6013, 2, 6, 0}, {6013, 5, 3, 0}, {6013, 5, 4, 0}// 193	194	195	
			, {6013, 7, 6, 0}, {6013, 3, 0, 0}, {6013, 5, 6, 0}// 196	197	198	
			, {6013, 3, 7, 0}, {6013, 2, 5, 0}, {6013, 5, 8, 0}// 199	200	201	
			, {6013, 6, 7, 0}, {6013, 3, 2, 0}, {6013, 6, 5, 0}// 202	203	204	
			, {6013, 4, 2, 0}, {6013, 4, 4, 0}, {6013, 7, 8, 0}// 205	206	207	
			, {6013, 3, 1, 0}, {6013, 4, 1, 0}, {6013, 6, 6, 0}// 208	209	210	
			, {6013, 2, 2, 0}, {6013, 3, 8, 0}, {6013, 2, 0, 0}// 211	212	213	
			, {6013, 3, 4, 0}, {6013, 3, 3, 0}, {6013, 7, 5, 0}// 214	215	216	
			, {6013, 5, 1, 0}// 217	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new grasstopperAddonDeed();
			}
		}

		[ Constructable ]
		public grasstopperAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public grasstopperAddon( Serial serial ) : base( serial )
		{
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

	public class grasstopperAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new grasstopperAddon();
			}
		}

		[Constructable]
		public grasstopperAddonDeed()
		{
			Name = "grasstopper";
		}

		public grasstopperAddonDeed( Serial serial ) : base( serial )
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