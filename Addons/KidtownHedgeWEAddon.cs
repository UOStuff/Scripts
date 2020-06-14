
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
	public class KidtownHedgeWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3513, -65, 0, 0}, {3513, -69, 0, 0}, {3513, -66, 0, 0}// 1	2	3	
			, {3513, -74, 0, 0}, {3513, -67, 0, 0}, {3513, -70, 0, 0}// 4	5	6	
			, {3513, -71, 0, 0}, {3513, -62, 0, 0}, {3513, -63, 0, 0}// 7	8	9	
			, {3513, -64, 0, 0}, {3513, -73, 0, 0}, {3513, -61, 0, 0}// 10	11	12	
			, {3513, -60, 0, 0}, {3513, -68, 0, 0}, {3513, -75, 0, 0}// 13	14	15	
			, {3513, -72, 0, 0}, {3513, -53, 0, 0}, {3513, -56, 0, 0}// 16	17	18	
			, {3513, -58, 0, 0}, {3513, -48, 0, 0}, {3513, -59, 0, 0}// 19	20	21	
			, {3513, -57, 0, 0}, {3513, -50, 0, 0}, {3513, -47, 0, 0}// 22	23	24	
			, {3513, -45, 0, 0}, {3513, -51, 0, 0}, {3513, -46, 0, 0}// 25	26	27	
			, {3513, -49, 0, 0}, {3513, -55, 0, 0}, {3513, -52, 0, 0}// 28	29	30	
			, {3513, -44, 0, 0}, {3513, -54, 0, 0}, {3513, -37, 0, 0}// 31	32	33	
			, {3513, -36, 0, 0}, {3513, -43, 0, 0}, {3513, -41, 0, 0}// 34	35	36	
			, {3513, -40, 0, 0}, {3513, -34, 0, 0}, {3513, -33, 0, 0}// 37	38	39	
			, {3513, -28, 0, 0}, {3513, -39, 0, 0}, {3513, -29, 0, 0}// 40	41	42	
			, {3513, -30, 0, 0}, {3513, -42, 0, 0}, {3513, -31, 0, 0}// 43	44	45	
			, {3513, -35, 0, 0}, {3513, -38, 0, 0}, {3513, -32, 0, 0}// 46	47	48	
			, {3513, -15, 0, 0}, {3513, -25, 0, 0}, {3513, -12, 0, 0}// 49	50	51	
			, {3513, -18, 0, 0}, {3513, -22, 0, 0}, {3513, -19, 0, 0}// 52	53	54	
			, {3513, -13, 0, 0}, {3513, -24, 0, 0}, {3513, -23, 0, 0}// 55	56	57	
			, {3513, -20, 0, 0}, {3513, -16, 0, 0}, {3513, -14, 0, 0}// 58	59	60	
			, {3513, -17, 0, 0}, {3513, -21, 0, 0}, {3513, -27, 0, 0}// 61	62	63	
			, {3513, -26, 0, 0}, {3513, -8, 0, 0}, {3513, -9, 0, 0}// 64	65	66	
			, {3513, -4, 0, 0}, {3513, -1, 0, 0}, {3513, -10, 0, 0}// 67	68	69	
			, {3513, -7, 0, 0}, {3513, -6, 0, 0}, {3513, -2, 0, 0}// 70	71	72	
			, {3513, -5, 0, 0}, {3513, 0, 0, 0}, {3513, 1, 0, 0}// 73	74	75	
			, {3513, 2, 0, 0}, {3513, 3, 0, 0}, {3513, 4, 0, 0}// 76	77	78	
			, {3513, -11, 0, 0}, {3513, -3, 0, 0}, {3513, 12, 0, 0}// 79	80	81	
			, {3513, 5, 0, 0}, {3513, 6, 0, 0}, {3513, 7, 0, 0}// 82	83	84	
			, {3513, 8, 0, 0}, {3513, 9, 0, 0}, {3513, 10, 0, 0}// 85	86	87	
			, {3513, 11, 0, 0}, {3513, 12, 0, 0}, {3513, 13, 0, 0}// 88	89	90	
			, {3513, 14, 0, 0}, {3513, 15, 0, 0}, {3513, 16, 0, 0}// 91	92	93	
			, {3513, 17, 0, 0}, {3513, 18, 0, 0}, {3513, 19, 0, 0}// 94	95	96	
			, {3513, 20, 0, 0}, {3513, 34, 0, 0}, {3513, 35, 0, 0}// 97	98	99	
			, {3513, 30, 0, 0}, {3513, 31, 0, 0}, {3513, 33, 0, 0}// 100	101	102	
			, {3513, 29, 0, 0}, {3513, 36, 0, 0}, {3513, 27, 0, 0}// 103	104	105	
			, {3513, 28, 0, 0}, {3513, 26, 0, 0}, {3513, 32, 0, 0}// 106	107	108	
			, {3513, 22, 0, 0}, {3513, 21, 0, 0}, {3513, 23, 0, 0}// 109	110	111	
			, {3513, 24, 0, 0}, {3513, 25, 0, 0}, {3513, 49, 0, 0}// 112	113	114	
			, {3513, 52, 0, 0}, {3513, 51, 0, 0}, {3513, 50, 0, 0}// 115	116	117	
			, {3512, 39, 0, 0}, {3513, 38, 0, 0}, {3513, 46, 0, 0}// 118	119	120	
			, {3513, 37, 0, 0}, {3513, 48, 0, 0}, {3513, 42, 0, 0}// 121	122	123	
			, {3513, 45, 0, 0}, {3513, 40, 0, 0}, {3513, 44, 0, 0}// 124	125	126	
			, {3513, 47, 0, 0}, {3513, 39, 0, 0}, {3513, 43, 0, 0}// 127	128	129	
			, {3512, 40, 0, 0}, {3512, 41, 0, 0}, {3513, 55, 0, 0}// 130	131	132	
			, {3513, 68, 0, 0}, {3513, 62, 0, 0}, {3513, 56, 0, 0}// 133	134	135	
			, {3513, 53, 0, 0}, {3513, 64, 0, 0}, {3513, 63, 0, 0}// 136	137	138	
			, {3513, 54, 0, 0}, {3513, 66, 0, 0}, {3513, 61, 0, 0}// 139	140	141	
			, {3513, 60, 0, 0}, {3513, 57, 0, 0}, {3513, 67, 0, 0}// 142	143	144	
			, {3513, 65, 0, 0}, {3513, 59, 0, 0}, {3513, 58, 0, 0}// 145	146	147	
			, {3513, 69, 0, 0}, {3513, 71, 0, 0}, {3513, 70, 0, 0}// 148	149	150	
			, {3513, 76, 0, 0}, {3513, 73, 0, 0}, {3513, 75, 0, 0}// 151	152	153	
			, {3513, 74, 0, 0}, {3513, 72, 0, 0}// 154	155	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KidtownHedgeWEAddonDeed();
			}
		}

		[ Constructable ]
		public KidtownHedgeWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public KidtownHedgeWEAddon( Serial serial ) : base( serial )
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

	public class KidtownHedgeWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KidtownHedgeWEAddon();
			}
		}

		[Constructable]
		public KidtownHedgeWEAddonDeed()
		{
			Name = "KidtownHedgeWE";
		}

		public KidtownHedgeWEAddonDeed( Serial serial ) : base( serial )
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