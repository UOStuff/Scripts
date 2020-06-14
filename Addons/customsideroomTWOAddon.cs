
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
	public class customsideroomTWOAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1955, -4, -5, 0}, {1955, -4, -4, 0}, {1955, -4, -3, 0}// 1	2	3	
			, {1955, -4, -2, 0}, {1955, -4, -1, 0}, {1955, -4, 0, 0}// 4	5	6	
			, {1955, -3, -5, 0}, {1955, -3, -4, 0}, {1955, -3, -3, 0}// 7	8	9	
			, {1955, -3, -2, 0}, {1955, -3, -1, 0}, {1955, -3, 0, 0}// 10	11	12	
			, {1955, -2, -5, 0}, {1955, -2, -4, 0}, {1955, -2, -3, 0}// 13	14	15	
			, {1955, -2, -2, 0}, {1955, -2, -1, 0}, {1955, -2, 0, 0}// 16	17	18	
			, {1955, -1, -5, 0}, {1955, -1, -4, 0}, {1955, -1, -3, 0}// 19	20	21	
			, {1955, -1, -2, 0}, {1955, -1, -1, 0}, {1955, -1, 0, 0}// 22	23	24	
			, {1955, 0, -5, 0}, {1955, 0, -4, 0}, {1955, 0, -3, 0}// 25	26	27	
			, {1955, 0, -2, 0}, {1955, 0, -1, 0}, {1955, 0, 0, 0}// 28	29	30	
			, {1955, 1, -5, 0}, {1955, 1, -4, 0}, {1955, 1, -3, 0}// 31	32	33	
			, {1955, 1, -2, 0}, {1955, 1, -1, 0}, {1955, 1, 0, 0}// 34	35	36	
			, {1955, 2, -5, 0}, {1955, 2, -4, 0}, {1955, 2, -3, 0}// 37	38	39	
			, {1955, 2, -2, 0}, {1955, 2, -1, 0}, {1955, 2, 0, 0}// 40	41	42	
			, {1955, 3, -5, 0}, {1955, 3, -4, 0}, {1955, 3, -3, 0}// 43	44	45	
			, {1955, 3, -2, 0}, {1955, 3, -1, 0}, {1955, 3, 0, 0}// 46	47	48	
			, {1301, -4, -5, 5}, {1301, -4, -4, 5}, {1301, -4, -3, 5}// 49	50	51	
			, {1301, -4, -2, 5}, {1301, -4, -1, 5}, {1301, -4, 0, 5}// 52	53	54	
			, {1301, -3, -5, 5}, {1301, -3, -4, 5}, {1301, -3, -3, 5}// 55	56	57	
			, {1301, -3, -2, 5}, {1301, -3, -1, 5}, {1301, -3, 0, 5}// 58	59	60	
			, {1301, -2, -5, 5}, {1301, -2, -4, 5}, {1301, -2, -3, 5}// 61	62	63	
			, {1301, -2, -2, 5}, {1301, -2, -1, 5}, {1301, -2, 0, 5}// 64	65	66	
			, {1301, -1, -5, 5}, {1301, -1, -4, 5}, {1301, -1, -3, 5}// 67	68	69	
			, {1301, -1, -2, 5}, {1301, -1, -1, 5}, {1301, -1, 0, 5}// 70	71	72	
			, {1301, 0, -5, 5}, {1301, 0, -4, 5}, {1301, 0, -3, 5}// 73	74	75	
			, {1301, 0, -2, 5}, {1301, 0, -1, 5}, {1301, 0, 0, 5}// 76	77	78	
			, {1301, 1, -5, 5}, {1301, 1, -4, 5}, {1301, 1, -3, 5}// 79	80	81	
			, {1301, 1, -2, 5}, {1301, 1, -1, 5}, {1301, 1, 0, 5}// 82	83	84	
			, {1301, 2, -5, 5}, {1301, 2, -4, 5}, {1301, 2, -3, 5}// 85	86	87	
			, {1301, 2, -2, 5}, {1301, 2, -1, 5}, {1301, 2, 0, 5}// 88	89	90	
			, {1301, 3, -5, 5}, {1301, 3, -4, 5}, {1301, 3, -3, 5}// 91	92	93	
			, {1301, 3, -2, 5}, {1301, 3, -1, 5}, {1301, 3, 0, 5}// 94	95	96	
			, {464, -4, -6, 5}, {464, -3, -6, 5}, {464, -2, -6, 5}// 97	98	99	
			, {464, -1, -6, 5}, {464, 0, -6, 5}, {464, 1, -6, 5}// 100	101	102	
			, {464, 2, -6, 5}, {464, 3, -6, 5}, {1314, -4, -5, 25}// 103	104	105	
			, {1314, -4, -4, 25}, {1314, -4, -3, 25}, {1314, -4, -2, 25}// 106	107	108	
			, {1314, -4, -1, 25}, {1314, -4, 0, 25}, {1314, -3, -5, 25}// 109	110	111	
			, {1314, -3, -4, 25}, {1314, -3, -3, 25}, {1314, -3, -2, 25}// 112	113	114	
			, {1314, -3, -1, 25}, {1314, -3, 0, 25}, {1314, -2, -5, 25}// 115	116	117	
			, {1314, -2, -4, 25}, {1314, -2, -3, 25}, {1314, -2, -2, 25}// 118	119	120	
			, {1314, -2, -1, 25}, {1314, -2, 0, 25}, {1314, -1, -5, 25}// 121	122	123	
			, {1314, -1, -4, 25}, {1314, -1, -3, 25}, {1314, -1, -2, 25}// 124	125	126	
			, {1314, -1, -1, 25}, {1314, -1, 0, 25}, {1314, 0, -5, 25}// 127	128	129	
			, {1314, 0, -4, 25}, {1314, 0, -3, 25}, {1314, 0, -2, 25}// 130	131	132	
			, {1314, 0, -1, 25}, {1314, 0, 0, 25}, {1314, 1, -5, 25}// 133	134	135	
			, {1314, 1, -4, 25}, {1314, 1, -3, 25}, {1314, 1, -2, 25}// 136	137	138	
			, {1314, 1, -1, 25}, {1314, 1, 0, 25}, {1314, 2, -5, 25}// 139	140	141	
			, {1314, 2, -4, 25}, {1314, 2, -3, 25}, {1314, 2, -2, 25}// 142	143	144	
			, {1314, 2, -1, 25}, {1314, 2, 0, 25}, {1314, 3, -5, 25}// 145	146	147	
			, {1314, 3, -4, 25}, {1314, 3, -3, 25}, {1314, 3, -2, 25}// 148	149	150	
			, {1314, 3, -1, 25}, {1314, 3, 0, 25}, {1955, -4, 1, 0}// 151	152	153	
			, {1955, -4, 2, 0}, {1955, -4, 3, 0}, {1955, -4, 4, 0}// 154	155	156	
			, {1955, -4, 5, 0}, {1955, -3, 1, 0}, {1955, -3, 2, 0}// 157	158	159	
			, {1955, -3, 3, 0}, {1955, -3, 4, 0}, {1955, -3, 5, 0}// 160	161	162	
			, {1955, -2, 1, 0}, {1955, -2, 2, 0}, {1955, -2, 3, 0}// 163	164	165	
			, {1955, -2, 4, 0}, {1955, -2, 5, 0}, {1955, -1, 1, 0}// 166	167	168	
			, {1955, -1, 2, 0}, {1955, -1, 3, 0}, {1955, -1, 4, 0}// 169	170	171	
			, {1955, -1, 5, 0}, {1955, 0, 1, 0}, {1955, 0, 2, 0}// 172	173	174	
			, {1955, 0, 3, 0}, {1955, 0, 4, 0}, {1955, 0, 5, 0}// 175	176	177	
			, {1955, 1, 1, 0}, {1955, 1, 2, 0}, {1955, 1, 3, 0}// 178	179	180	
			, {1955, 1, 4, 0}, {1955, 1, 5, 0}, {1955, 2, 1, 0}// 181	182	183	
			, {1955, 2, 2, 0}, {1955, 2, 3, 0}, {1955, 2, 4, 0}// 184	185	186	
			, {1955, 2, 5, 0}, {1955, 3, 1, 0}, {1955, 3, 2, 0}// 187	188	189	
			, {1955, 3, 3, 0}, {1955, 3, 4, 0}, {1955, 3, 5, 0}// 190	191	192	
			, {1955, -4, 6, 0}, {1955, -3, 6, 0}, {1955, -2, 6, 0}// 193	194	195	
			, {1955, -1, 6, 0}, {1955, 0, 6, 0}, {1955, 1, 6, 0}// 196	197	198	
			, {1955, 2, 6, 0}, {1955, 3, 6, 0}, {1955, -4, 7, 0}// 199	200	201	
			, {1955, -3, 7, 0}, {1955, -2, 7, 0}, {1955, -1, 7, 0}// 202	203	204	
			, {1955, 0, 7, 0}, {1955, 1, 7, 0}, {1955, 2, 7, 0}// 205	206	207	
			, {1955, 3, 7, 0}, {1301, -4, 1, 5}, {1301, -4, 2, 5}// 208	209	210	
			, {1301, -4, 3, 5}, {1301, -4, 4, 5}, {1301, -4, 5, 5}// 211	212	213	
			, {1301, -4, 6, 5}, {1301, -4, 7, 5}, {1301, -3, 1, 5}// 214	215	216	
			, {1301, -3, 2, 5}, {1301, -3, 3, 5}, {1301, -3, 4, 5}// 217	218	219	
			, {1301, -3, 5, 5}, {1301, -3, 6, 5}, {1301, -3, 7, 5}// 220	221	222	
			, {1301, -2, 1, 5}, {1301, -2, 2, 5}, {1301, -2, 3, 5}// 223	224	225	
			, {1301, -2, 4, 5}, {1301, -2, 5, 5}, {1301, -2, 6, 5}// 226	227	228	
			, {1301, -2, 7, 5}, {1301, -1, 1, 5}, {1301, -1, 2, 5}// 229	230	231	
			, {1301, -1, 3, 5}, {1301, -1, 4, 5}, {1301, -1, 5, 5}// 232	233	234	
			, {1301, -1, 6, 5}, {1301, -1, 7, 5}, {1301, 0, 1, 5}// 235	236	237	
			, {1301, 0, 2, 5}, {1301, 0, 3, 5}, {1301, 0, 4, 5}// 238	239	240	
			, {1301, 0, 5, 5}, {1301, 0, 6, 5}, {1301, 0, 7, 5}// 241	242	243	
			, {1301, 1, 1, 5}, {1301, 1, 2, 5}, {1301, 1, 3, 5}// 244	245	246	
			, {1301, 1, 4, 5}, {1301, 1, 5, 5}, {1301, 1, 6, 5}// 247	248	249	
			, {1301, 1, 7, 5}, {1301, 2, 1, 5}, {1301, 2, 2, 5}// 250	251	252	
			, {1301, 2, 3, 5}, {1301, 2, 4, 5}, {1301, 2, 5, 5}// 253	254	255	
			, {1301, 2, 6, 5}, {1301, 2, 7, 5}, {1301, 3, 1, 5}// 256	257	258	
			, {1301, 3, 2, 5}, {1301, 3, 3, 5}, {1301, 3, 4, 5}// 259	260	261	
			, {1301, 3, 5, 5}, {1301, 3, 6, 5}, {1301, 3, 7, 5}// 262	263	264	
			, {464, -4, 7, 5}, {464, -3, 7, 5}, {464, -2, 7, 5}// 265	266	267	
			, {464, -1, 7, 5}, {464, 0, 7, 5}, {464, 1, 7, 5}// 268	269	270	
			, {464, 2, 7, 5}, {464, 3, 7, 5}, {1314, -4, 1, 25}// 271	272	273	
			, {1314, -4, 2, 25}, {1314, -4, 3, 25}, {1314, -4, 4, 25}// 274	275	276	
			, {1314, -4, 5, 25}, {1314, -4, 6, 25}, {1314, -4, 7, 25}// 277	278	279	
			, {1314, -3, 1, 25}, {1314, -3, 2, 25}, {1314, -3, 3, 25}// 280	281	282	
			, {1314, -3, 4, 25}, {1314, -3, 5, 25}, {1314, -3, 6, 25}// 283	284	285	
			, {1314, -3, 7, 25}, {1314, -2, 1, 25}, {1314, -2, 2, 25}// 286	287	288	
			, {1314, -2, 3, 25}, {1314, -2, 4, 25}, {1314, -2, 5, 25}// 289	290	291	
			, {1314, -2, 6, 25}, {1314, -2, 7, 25}, {1314, -1, 1, 25}// 292	293	294	
			, {1314, -1, 2, 25}, {1314, -1, 3, 25}, {1314, -1, 4, 25}// 295	296	297	
			, {1314, -1, 5, 25}, {1314, -1, 6, 25}, {1314, -1, 7, 25}// 298	299	300	
			, {1314, 0, 1, 25}, {1314, 0, 2, 25}, {1314, 0, 3, 25}// 301	302	303	
			, {1314, 0, 4, 25}, {1314, 0, 5, 25}, {1314, 0, 6, 25}// 304	305	306	
			, {1314, 0, 7, 25}, {1314, 1, 1, 25}, {1314, 1, 2, 25}// 307	308	309	
			, {1314, 1, 3, 25}, {1314, 1, 4, 25}, {1314, 1, 5, 25}// 310	311	312	
			, {1314, 1, 6, 25}, {1314, 1, 7, 25}, {1314, 2, 1, 25}// 313	314	315	
			, {1314, 2, 2, 25}, {1314, 2, 3, 25}, {1314, 2, 4, 25}// 316	317	318	
			, {1314, 2, 5, 25}, {1314, 2, 6, 25}, {1314, 2, 7, 25}// 319	320	321	
			, {1314, 3, 1, 25}, {1314, 3, 2, 25}, {1314, 3, 3, 25}// 322	323	324	
			, {1314, 3, 4, 25}, {1314, 3, 5, 25}, {1314, 3, 6, 25}// 325	326	327	
			, {1314, 3, 7, 25}, {1955, 4, -5, 0}, {1955, 4, -4, 0}// 328	329	330	
			, {1955, 4, -3, 0}, {1955, 4, -2, 0}, {1955, 4, -1, 0}// 331	332	333	
			, {1955, 4, 0, 0}, {1301, 4, -5, 5}, {1301, 4, -4, 5}// 334	335	336	
			, {1301, 4, -3, 5}, {1301, 4, -2, 5}, {1301, 4, -1, 5}// 337	338	339	
			, {1301, 4, 0, 5}, {464, 4, -6, 5}, {465, 4, -5, 5}// 340	341	342	
			, {465, 4, -4, 5}, {465, 4, -3, 5}, {465, 4, -2, 5}// 343	344	345	
			, {465, 4, -1, 5}, {1314, 4, -5, 25}, {1314, 4, -4, 25}// 346	347	348	
			, {1314, 4, -3, 25}, {1314, 4, -2, 25}, {1314, 4, -1, 25}// 349	350	351	
			, {1314, 4, 0, 25}, {489, 4, -6, 0}, {489, 4, -6, 3}// 352	353	354	
			, {1955, 4, 1, 0}, {1955, 4, 2, 0}, {1955, 4, 3, 0}// 355	356	357	
			, {1955, 4, 4, 0}, {1955, 4, 5, 0}, {1955, 4, 6, 0}// 358	359	360	
			, {1955, 4, 7, 0}, {1301, 4, 1, 5}, {1301, 4, 2, 5}// 361	362	363	
			, {1301, 4, 3, 5}, {1301, 4, 4, 5}, {1301, 4, 5, 5}// 364	365	366	
			, {1301, 4, 6, 5}, {1301, 4, 7, 5}, {463, 4, 7, 5}// 367	368	369	
			, {465, 4, 2, 5}, {465, 4, 3, 5}, {465, 4, 4, 5}// 370	371	372	
			, {465, 4, 5, 5}, {465, 4, 6, 5}, {1314, 4, 1, 25}// 373	374	375	
			, {1314, 4, 2, 25}, {1314, 4, 3, 25}, {1314, 4, 4, 25}// 376	377	378	
			, {1314, 4, 5, 25}, {1314, 4, 6, 25}, {1314, 4, 7, 25}// 379	380	381	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new customsideroomTWOAddonDeed();
			}
		}

		[ Constructable ]
		public customsideroomTWOAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public customsideroomTWOAddon( Serial serial ) : base( serial )
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

	public class customsideroomTWOAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new customsideroomTWOAddon();
			}
		}

		[Constructable]
		public customsideroomTWOAddonDeed()
		{
			Name = "customsideroomTWO";
		}

		public customsideroomTWOAddonDeed( Serial serial ) : base( serial )
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