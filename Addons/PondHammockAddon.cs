
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
	public class PondHammockAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3221, -2, -6, 0}, {3221, 2, -6, 0}, {4592, -1, -6, 0}// 1	2	3	
			, {4593, 1, -6, 0}, {2874, -1, -5, 0}, {2463, -1, -5, 3}// 4	5	6	
			, {2458, -1, -5, 7}, {6039, -2, 0, 0}, {6039, -1, -1, 0}// 7	8	9	
			, {6039, -1, 0, 0}, {6039, 0, -1, 0}, {6039, 0, 0, 0}// 10	11	12	
			, {6039, 1, -1, 0}, {6039, 1, 0, 0}, {6039, 2, -1, 0}// 13	14	15	
			, {6039, 2, 0, 0}, {6039, -3, 1, 0}, {6039, -3, 2, 0}// 16	17	18	
			, {6039, -3, 3, 0}, {6039, -2, 1, 0}, {6039, -2, 2, 0}// 19	20	21	
			, {6039, -2, 3, 0}, {6039, -1, 1, 0}, {6039, -1, 2, 0}// 22	23	24	
			, {6039, -1, 3, 0}, {6039, 0, 1, 0}, {6039, 0, 2, 0}// 25	26	27	
			, {6039, 0, 3, 0}, {6039, 1, 1, 0}, {6039, 1, 2, 0}// 28	29	30	
			, {6039, 1, 3, 0}, {6039, 2, 1, 0}, {6039, 2, 2, 0}// 31	32	33	
			, {6039, 2, 3, 0}, {6039, 3, 0, 0}, {6039, 3, 1, 0}// 34	35	36	
			, {6039, 3, 2, 0}, {6039, 3, 3, 0}, {6039, 4, 1, 0}// 37	38	39	
			, {6039, 4, 2, 0}, {6039, 4, 3, 0}, {6039, 0, -2, 0}// 40	41	42	
			, {6039, 1, -2, 0}, {6045, 5, 2, 0}, {6047, 1, -3, 0}// 43	44	45	
			, {6048, 0, -3, 0}, {6051, -4, 3, 0}, {6051, -4, 1, 0}// 46	47	48	
			, {6052, -4, 2, 0}, {6046, 5, 3, 0}, {6046, 5, 1, 0}// 49	50	51	
			, {6057, 4, 0, 0}, {6057, 3, -1, 0}, {6057, 2, -2, 0}// 52	53	54	
			, {6060, -3, 0, 0}, {6060, -2, -1, 0}, {6060, -1, -2, 0}// 55	56	57	
			, {6054, -4, 0, 0}, {6054, -3, -1, 0}, {6054, -2, -2, 0}// 58	59	60	
			, {6054, -1, -3, 0}, {6053, 2, -3, 0}, {6053, 3, -2, 0}// 61	62	63	
			, {6053, 4, -1, 0}, {6053, 5, 0, 0}, {4943, -4, 0, 0}// 64	65	66	
			, {4944, -3, 0, 0}, {4945, -3, -1, 0}, {4946, -2, -1, 0}// 67	68	69	
			, {4947, -1, -1, 0}, {4948, -1, -2, 0}, {4950, -3, 1, 0}// 70	71	72	
			, {4951, -2, 0, 0}, {4952, -1, 0, 0}, {4953, -1, -1, 0}// 73	74	75	
			, {4949, -3, 2, 0}, {4954, -4, 2, 0}, {4955, -4, 1, 0}// 76	77	78	
			, {3220, -4, 3, 0}, {3259, -3, -2, 0}, {3259, -1, -3, 0}// 79	80	81	
			, {3259, -5, 0, 0}, {3259, -5, 2, 0}, {3233, -1, -1, 15}// 82	83	84	
			, {3237, -2, 0, 0}, {3237, 0, -2, 0}, {3239, -2, 1, 0}// 85	86	87	
			, {3239, 0, -1, 0}, {3241, -5, 1, 0}, {3241, -2, -3, 0}// 88	89	90	
			, {3241, 0, -3, 0}, {3241, -5, 3, 0}, {3208, -3, 3, 3}// 91	92	93	
			, {3332, -2, 2, 3}, {3332, 0, 0, 3}, {3211, -3, 1, 5}// 94	95	96	
			, {4973, 5, 2, 0}, {6004, 4, -1, 0}, {6010, 1, -3, 0}// 97	98	99	
			, {6039, -2, 4, 0}, {6039, -1, 4, 0}, {6039, 0, 4, 0}// 100	101	102	
			, {6039, 1, 4, 0}, {6039, 2, 4, 0}, {6039, 3, 4, 0}// 103	104	105	
			, {6039, -1, 5, 0}, {6039, 0, 5, 0}, {6039, 1, 5, 0}// 106	107	108	
			, {6039, 2, 5, 0}, {6039, 0, 6, 0}, {6039, 1, 6, 0}// 109	110	111	
			, {6049, 0, 7, 0}, {6050, 1, 7, 0}, {6058, 4, 4, 0}// 112	113	114	
			, {6058, 3, 5, 0}, {6058, 2, 6, 0}, {6059, -1, 6, 0}// 115	116	117	
			, {6059, -2, 5, 0}, {6059, -3, 4, 0}, {6056, -4, 4, 0}// 118	119	120	
			, {6056, -3, 5, 0}, {6056, -2, 6, 0}, {6056, -1, 7, 0}// 121	122	123	
			, {6055, 2, 7, 0}, {6055, 3, 6, 0}, {6055, 4, 5, 0}// 124	125	126	
			, {6055, 5, 4, 0}, {3224, 5, 4, 0}, {3224, 2, 7, 0}// 127	128	129	
			, {3204, 2, 7, 8}, {3204, 5, 4, 9}, {3225, 3, 6, 4}// 130	131	132	
			, {3229, 4, 5, 4}, {3238, 4, 6, 0}, {3238, 5, 5, 0}// 133	134	135	
			, {3238, 3, 7, 0}, {4967, 5, 4, 0}, {4967, 2, 7, 0}// 136	137	138	
			, {4970, 0, 7, 0}, {6012, -2, 5, 0}, {6011, -1, 6, 0}// 139	140	141	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PondHammockAddonDeed();
			}
		}

		[ Constructable ]
		public PondHammockAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public PondHammockAddon( Serial serial ) : base( serial )
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

	public class PondHammockAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PondHammockAddon();
			}
		}

		[Constructable]
		public PondHammockAddonDeed()
		{
			Name = "PondHammock";
		}

		public PondHammockAddonDeed( Serial serial ) : base( serial )
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