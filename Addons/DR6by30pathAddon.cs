
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
	public class DR6by30pathAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1277, -14, -2, 0}, {1277, -13, -2, 0}, {1277, -12, -2, 0}// 1	2	3	
			, {1277, -11, -2, 0}, {1277, -10, -2, 0}, {1277, -14, -1, 0}// 4	5	6	
			, {1277, -14, 0, 0}, {1277, -14, 1, 0}, {1277, -14, 2, 0}// 7	8	9	
			, {1277, -13, -1, 0}, {1277, -13, 0, 0}, {1277, -13, 1, 0}// 10	11	12	
			, {1277, -13, 2, 0}, {1277, -12, -1, 0}, {1277, -12, 0, 0}// 13	14	15	
			, {1277, -12, 1, 0}, {1277, -12, 2, 0}, {1277, -11, -1, 0}// 16	17	18	
			, {1277, -11, 0, 0}, {1277, -11, 1, 0}, {1277, -11, 2, 0}// 19	20	21	
			, {1277, -10, -1, 0}, {1277, -10, 0, 0}, {1277, -10, 1, 0}// 22	23	24	
			, {1277, -10, 2, 0}, {1277, -14, 3, 0}, {1277, -13, 3, 0}// 25	26	27	
			, {1277, -12, 3, 0}, {1277, -11, 3, 0}, {1277, -10, 3, 0}// 28	29	30	
			, {1277, -9, -2, 0}, {1277, -8, -2, 0}, {1277, -7, -2, 0}// 31	32	33	
			, {1277, -6, -2, 0}, {1277, -5, -2, 0}, {1277, -4, -2, 0}// 34	35	36	
			, {1277, -3, -2, 0}, {1277, -2, -2, 0}, {1277, -1, -2, 0}// 37	38	39	
			, {1277, 0, -2, 0}, {1277, 1, -2, 0}, {1277, 2, -2, 0}// 40	41	42	
			, {1277, 3, -2, 0}, {1277, 4, -2, 0}, {1277, 5, -2, 0}// 43	44	45	
			, {1277, 6, -2, 0}, {1277, -9, -1, 0}, {1277, -9, 0, 0}// 46	47	48	
			, {1277, -9, 1, 0}, {1277, -9, 2, 0}, {1277, -8, -1, 0}// 49	50	51	
			, {1277, -8, 0, 0}, {1277, -8, 1, 0}, {1277, -8, 2, 0}// 52	53	54	
			, {1277, -7, -1, 0}, {1277, -7, 0, 0}, {1277, -7, 1, 0}// 55	56	57	
			, {1277, -7, 2, 0}, {1277, -6, -1, 0}, {1277, -6, 0, 0}// 58	59	60	
			, {1277, -6, 1, 0}, {1277, -6, 2, 0}, {1277, -5, -1, 0}// 61	62	63	
			, {1277, -5, 0, 0}, {1277, -5, 1, 0}, {1277, -5, 2, 0}// 64	65	66	
			, {1277, -4, -1, 0}, {1277, -4, 0, 0}, {1277, -4, 1, 0}// 67	68	69	
			, {1277, -4, 2, 0}, {1277, -3, -1, 0}, {1277, -3, 0, 0}// 70	71	72	
			, {1277, -3, 1, 0}, {1277, -3, 2, 0}, {1277, -2, -1, 0}// 73	74	75	
			, {1277, -2, 0, 0}, {1277, -2, 1, 0}, {1277, -2, 2, 0}// 76	77	78	
			, {1277, -1, -1, 0}, {1277, -1, 0, 0}, {1277, -1, 1, 0}// 79	80	81	
			, {1277, -1, 2, 0}, {1277, 0, -1, 0}, {1277, 0, 0, 0}// 82	83	84	
			, {1277, 0, 1, 0}, {1277, 0, 2, 0}, {1277, 1, -1, 0}// 85	86	87	
			, {1277, 1, 0, 0}, {1277, 1, 1, 0}, {1277, 1, 2, 0}// 88	89	90	
			, {1277, 2, -1, 0}, {1277, 2, 0, 0}, {1277, 2, 1, 0}// 91	92	93	
			, {1277, 2, 2, 0}, {1277, 3, -1, 0}, {1277, 3, 0, 0}// 94	95	96	
			, {1277, 3, 1, 0}, {1277, 3, 2, 0}, {1277, 4, -1, 0}// 97	98	99	
			, {1277, 4, 0, 0}, {1277, 4, 1, 0}, {1277, 4, 2, 0}// 100	101	102	
			, {1277, 5, -1, 0}, {1277, 5, 0, 0}, {1277, 5, 1, 0}// 103	104	105	
			, {1277, 5, 2, 0}, {1277, 6, -1, 0}, {1277, 6, 0, 0}// 106	107	108	
			, {1277, 6, 1, 0}, {1277, 6, 2, 0}, {1277, -9, 3, 0}// 109	110	111	
			, {1277, -8, 3, 0}, {1277, -7, 3, 0}, {1277, -6, 3, 0}// 112	113	114	
			, {1277, -5, 3, 0}, {1277, -4, 3, 0}, {1277, -3, 3, 0}// 115	116	117	
			, {1277, -2, 3, 0}, {1277, -1, 3, 0}, {1277, 0, 3, 0}// 118	119	120	
			, {1277, 1, 3, 0}, {1277, 2, 3, 0}, {1277, 3, 3, 0}// 121	122	123	
			, {1277, 4, 3, 0}, {1277, 5, 3, 0}, {1277, 6, 3, 0}// 124	125	126	
			, {1277, 7, -2, 0}, {1277, 8, -2, 0}, {1277, 9, -2, 0}// 127	128	129	
			, {1277, 10, -2, 0}, {1277, 11, -2, 0}, {1277, 12, -2, 0}// 130	131	132	
			, {1277, 13, -2, 0}, {1277, 14, -2, 0}, {1277, 15, -2, 0}// 133	134	135	
			, {1277, 7, -1, 0}, {1277, 7, 0, 0}, {1277, 7, 1, 0}// 136	137	138	
			, {1277, 7, 2, 0}, {1277, 8, -1, 0}, {1277, 8, 0, 0}// 139	140	141	
			, {1277, 8, 1, 0}, {1277, 8, 2, 0}, {1277, 9, -1, 0}// 142	143	144	
			, {1277, 9, 0, 0}, {1277, 9, 1, 0}, {1277, 9, 2, 0}// 145	146	147	
			, {1277, 10, -1, 0}, {1277, 10, 0, 0}, {1277, 10, 1, 0}// 148	149	150	
			, {1277, 10, 2, 0}, {1277, 11, -1, 0}, {1277, 11, 0, 0}// 151	152	153	
			, {1277, 11, 1, 0}, {1277, 11, 2, 0}, {1277, 12, -1, 0}// 154	155	156	
			, {1277, 12, 0, 0}, {1277, 12, 1, 0}, {1277, 12, 2, 0}// 157	158	159	
			, {1277, 13, -1, 0}, {1277, 13, 0, 0}, {1277, 13, 1, 0}// 160	161	162	
			, {1277, 13, 2, 0}, {1277, 14, -1, 0}, {1277, 14, 0, 0}// 163	164	165	
			, {1277, 14, 1, 0}, {1277, 14, 2, 0}, {1277, 15, -1, 0}// 166	167	168	
			, {1277, 15, 0, 0}, {1277, 15, 1, 0}, {1277, 15, 2, 0}// 169	170	171	
			, {1277, 7, 3, 0}, {1277, 8, 3, 0}, {1277, 9, 3, 0}// 172	173	174	
			, {1277, 10, 3, 0}, {1277, 11, 3, 0}, {1277, 12, 3, 0}// 175	176	177	
			, {1277, 13, 3, 0}, {1277, 14, 3, 0}, {1277, 15, 3, 0}// 178	179	180	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DR6by30pathAddonDeed();
			}
		}

		[ Constructable ]
		public DR6by30pathAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public DR6by30pathAddon( Serial serial ) : base( serial )
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

	public class DR6by30pathAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DR6by30pathAddon();
			}
		}

		[Constructable]
		public DR6by30pathAddonDeed()
		{
			Name = "DR6by30path";
		}

		public DR6by30pathAddonDeed( Serial serial ) : base( serial )
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