
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
	public class DRalchemtbuildingfloorAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1339, -6, -6, 0}, {1339, -5, -6, 0}, {1339, -4, -6, 0}// 1	2	3	
			, {1339, -3, -6, 0}, {1339, -2, -6, 0}, {1339, -1, -6, 0}// 4	5	6	
			, {1339, 0, -6, 0}, {1339, 1, -6, 0}, {1339, 2, -6, 0}// 7	8	9	
			, {1339, 3, -6, 0}, {1339, 4, -6, 0}, {1339, 5, -6, 0}// 10	11	12	
			, {1339, -6, -5, 0}, {1339, -6, -4, 0}, {1339, -6, -3, 0}// 13	14	15	
			, {1339, -6, -2, 0}, {1339, -6, -1, 0}, {1339, -6, 0, 0}// 16	17	18	
			, {1339, -6, 1, 0}, {1339, -6, 2, 0}, {1339, -6, 3, 0}// 19	20	21	
			, {1339, -6, 4, 0}, {1339, -6, 5, 0}, {1339, -6, 6, 0}// 22	23	24	
			, {1339, -6, 7, 0}, {1339, -5, -5, 0}, {1339, -5, -4, 0}// 25	26	27	
			, {1339, -5, -3, 0}, {1339, -5, -2, 0}, {1339, -5, -1, 0}// 28	29	30	
			, {1339, -5, 0, 0}, {1339, -5, 1, 0}, {1339, -5, 2, 0}// 31	32	33	
			, {1339, -5, 3, 0}, {1339, -5, 4, 0}, {1339, -5, 5, 0}// 34	35	36	
			, {1339, -5, 6, 0}, {1339, -5, 7, 0}, {1339, -4, -5, 0}// 37	38	39	
			, {1339, -4, -4, 0}, {1339, -4, -3, 0}, {1339, -4, -2, 0}// 40	41	42	
			, {1339, -4, -1, 0}, {1339, -4, 0, 0}, {1339, -4, 1, 0}// 43	44	45	
			, {1339, -4, 2, 0}, {1339, -4, 3, 0}, {1339, -4, 4, 0}// 46	47	48	
			, {1339, -4, 5, 0}, {1339, -4, 6, 0}, {1339, -4, 7, 0}// 49	50	51	
			, {1339, -3, -5, 0}, {1339, -3, -4, 0}, {1339, -3, -3, 0}// 52	53	54	
			, {1339, -3, -2, 0}, {1339, -3, -1, 0}, {1339, -3, 0, 0}// 55	56	57	
			, {1339, -3, 1, 0}, {1339, -3, 2, 0}, {1339, -3, 3, 0}// 58	59	60	
			, {1339, -3, 4, 0}, {1339, -3, 5, 0}, {1339, -3, 6, 0}// 61	62	63	
			, {1339, -3, 7, 0}, {1339, -2, -5, 0}, {1339, -2, -4, 0}// 64	65	66	
			, {1339, -2, -3, 0}, {1339, -2, -2, 0}, {1339, -2, -1, 0}// 67	68	69	
			, {1339, -2, 0, 0}, {1339, -2, 1, 0}, {1339, -2, 2, 0}// 70	71	72	
			, {1339, -2, 3, 0}, {1339, -2, 4, 0}, {1339, -2, 5, 0}// 73	74	75	
			, {1339, -2, 6, 0}, {1339, -2, 7, 0}, {1339, -1, -5, 0}// 76	77	78	
			, {1339, -1, -4, 0}, {1339, -1, -3, 0}, {1339, -1, -2, 0}// 79	80	81	
			, {1339, -1, -1, 0}, {1339, -1, 0, 0}, {1339, -1, 1, 0}// 82	83	84	
			, {1339, -1, 2, 0}, {1339, -1, 3, 0}, {1339, -1, 4, 0}// 85	86	87	
			, {1339, -1, 5, 0}, {1339, -1, 6, 0}, {1339, -1, 7, 0}// 88	89	90	
			, {1339, 0, -5, 0}, {1339, 0, -4, 0}, {1339, 0, -3, 0}// 91	92	93	
			, {1339, 0, -2, 0}, {1339, 0, -1, 0}, {1339, 0, 0, 0}// 94	95	96	
			, {1339, 0, 1, 0}, {1339, 0, 2, 0}, {1339, 0, 3, 0}// 97	98	99	
			, {1339, 0, 4, 0}, {1339, 0, 5, 0}, {1339, 0, 6, 0}// 100	101	102	
			, {1339, 0, 7, 0}, {1339, 1, -5, 0}, {1339, 1, -4, 0}// 103	104	105	
			, {1339, 1, -3, 0}, {1339, 1, -2, 0}, {1339, 1, -1, 0}// 106	107	108	
			, {1339, 1, 0, 0}, {1339, 1, 1, 0}, {1339, 1, 2, 0}// 109	110	111	
			, {1339, 1, 3, 0}, {1339, 1, 4, 0}, {1339, 1, 5, 0}// 112	113	114	
			, {1339, 1, 6, 0}, {1339, 1, 7, 0}, {1339, 2, -5, 0}// 115	116	117	
			, {1339, 2, -4, 0}, {1339, 2, -3, 0}, {1339, 2, -2, 0}// 118	119	120	
			, {1339, 2, -1, 0}, {1339, 2, 0, 0}, {1339, 2, 1, 0}// 121	122	123	
			, {1339, 2, 2, 0}, {1339, 2, 3, 0}, {1339, 2, 4, 0}// 124	125	126	
			, {1339, 2, 5, 0}, {1339, 2, 6, 0}, {1339, 2, 7, 0}// 127	128	129	
			, {1339, 3, -5, 0}, {1339, 3, -4, 0}, {1339, 3, -3, 0}// 130	131	132	
			, {1339, 3, -2, 0}, {1339, 3, -1, 0}, {1339, 3, 0, 0}// 133	134	135	
			, {1339, 3, 1, 0}, {1339, 3, 2, 0}, {1339, 3, 3, 0}// 136	137	138	
			, {1339, 3, 4, 0}, {1339, 3, 5, 0}, {1339, 3, 6, 0}// 139	140	141	
			, {1339, 3, 7, 0}, {1339, 4, -5, 0}, {1339, 4, -4, 0}// 142	143	144	
			, {1339, 4, -3, 0}, {1339, 4, -2, 0}, {1339, 4, -1, 0}// 145	146	147	
			, {1339, 4, 0, 0}, {1339, 4, 1, 0}, {1339, 4, 2, 0}// 148	149	150	
			, {1339, 4, 3, 0}, {1339, 4, 4, 0}, {1339, 4, 5, 0}// 151	152	153	
			, {1339, 4, 6, 0}, {1339, 4, 7, 0}, {1339, 5, -5, 0}// 154	155	156	
			, {1339, 5, -4, 0}, {1339, 5, -3, 0}, {1339, 5, -2, 0}// 157	158	159	
			, {1339, 5, -1, 0}, {1339, 5, 0, 0}, {1339, 5, 1, 0}// 160	161	162	
			, {1339, 5, 2, 0}, {1339, 5, 3, 0}, {1339, 5, 4, 0}// 163	164	165	
			, {1339, 5, 5, 0}, {1339, 5, 6, 0}, {1339, 5, 7, 0}// 166	167	168	
			, {1339, 6, -6, 0}, {1339, 7, -6, 0}, {1339, 6, -5, 0}// 169	170	171	
			, {1339, 6, -4, 0}, {1339, 6, -3, 0}, {1339, 6, -2, 0}// 172	173	174	
			, {1339, 6, -1, 0}, {1339, 6, 0, 0}, {1339, 6, 1, 0}// 175	176	177	
			, {1339, 6, 2, 0}, {1339, 6, 3, 0}, {1339, 6, 4, 0}// 178	179	180	
			, {1339, 6, 5, 0}, {1339, 6, 6, 0}, {1339, 6, 7, 0}// 181	182	183	
			, {1339, 7, -5, 0}, {1339, 7, -4, 0}, {1339, 7, -3, 0}// 184	185	186	
			, {1339, 7, -2, 0}, {1339, 7, -1, 0}, {1339, 7, 0, 0}// 187	188	189	
			, {1339, 7, 1, 0}, {1339, 7, 2, 0}, {1339, 7, 3, 0}// 190	191	192	
			, {1339, 7, 4, 0}, {1339, 7, 5, 0}, {1339, 7, 6, 0}// 193	194	195	
			, {1339, 7, 7, 0}// 196	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DRalchemtbuildingfloorAddonDeed();
			}
		}

		[ Constructable ]
		public DRalchemtbuildingfloorAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public DRalchemtbuildingfloorAddon( Serial serial ) : base( serial )
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

	public class DRalchemtbuildingfloorAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DRalchemtbuildingfloorAddon();
			}
		}

		[Constructable]
		public DRalchemtbuildingfloorAddonDeed()
		{
			Name = "DRalchemtbuildingfloor";
		}

		public DRalchemtbuildingfloorAddonDeed( Serial serial ) : base( serial )
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