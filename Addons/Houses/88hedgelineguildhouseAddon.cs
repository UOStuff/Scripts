
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
	public class eightyeighthedgelineguildhouseAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3512, -226, 0, 0}, {3512, -217, 0, 0}, {3512, -216, 0, 0}// 1	2	3	
			, {3512, -220, 0, 0}, {3512, -221, 0, 0}, {3512, -210, 0, 0}// 4	5	6	
			, {3512, -222, 0, 0}, {3512, -223, 0, 0}, {3512, -225, 0, 0}// 7	8	9	
			, {3512, -211, 0, 0}, {3512, -212, 0, 0}, {3512, -213, 0, 0}// 10	11	12	
			, {3512, -214, 0, 0}, {3512, -215, 0, 0}, {3512, -218, 0, 0}// 13	14	15	
			, {3512, -224, 0, 0}, {3512, -219, 0, 0}, {3512, -200, 0, 0}// 16	17	18	
			, {3512, -202, 0, 0}, {3512, -205, 0, 0}, {3512, -196, 0, 0}// 19	20	21	
			, {3512, -207, 0, 0}, {3512, -203, 0, 0}, {3512, -197, 0, 0}// 22	23	24	
			, {3512, -194, 0, 0}, {3512, -195, 0, 0}, {3512, -198, 0, 0}// 25	26	27	
			, {3512, -201, 0, 0}, {3512, -206, 0, 0}, {3512, -199, 0, 0}// 28	29	30	
			, {3512, -208, 0, 0}, {3512, -209, 0, 0}, {3512, -204, 0, 0}// 31	32	33	
			, {3512, -191, 0, 0}, {3512, -192, 0, 0}, {3512, -180, 0, 0}// 34	35	36	
			, {3512, -185, 0, 0}, {3512, -183, 0, 0}, {3512, -181, 0, 0}// 37	38	39	
			, {3512, -190, 0, 0}, {3512, -184, 0, 0}, {3512, -182, 0, 0}// 40	41	42	
			, {3512, -186, 0, 0}, {3512, -193, 0, 0}, {3512, -178, 0, 0}// 43	44	45	
			, {3512, -179, 0, 0}, {3512, -187, 0, 0}, {3512, -189, 0, 0}// 46	47	48	
			, {3512, -188, 0, 0}, {3512, -165, 0, 0}, {3512, -162, 0, 0}// 49	50	51	
			, {3512, -166, 0, 0}, {3512, -173, 0, 0}, {3512, -171, 0, 0}// 52	53	54	
			, {3512, -172, 0, 0}, {3512, -164, 0, 0}, {3512, -174, 0, 0}// 55	56	57	
			, {3512, -163, 0, 0}, {3512, -167, 0, 0}, {3512, -169, 0, 0}// 58	59	60	
			, {3512, -168, 0, 0}, {3512, -170, 0, 0}, {3512, -154, 0, 0}// 61	62	63	
			, {3512, -158, 0, 0}, {3512, -160, 0, 0}, {3512, -153, 0, 0}// 64	65	66	
			, {3512, -151, 0, 0}, {3512, -161, 0, 0}, {3512, -156, 0, 0}// 67	68	69	
			, {3512, -155, 0, 0}, {3512, -157, 0, 0}, {3512, -146, 0, 0}// 70	71	72	
			, {3512, -159, 0, 0}, {3512, -149, 0, 0}, {3512, -147, 0, 0}// 73	74	75	
			, {3512, -150, 0, 0}, {3512, -152, 0, 0}, {3512, -148, 0, 0}// 76	77	78	
			, {3512, -135, 0, 0}, {3512, -136, 0, 0}, {3512, -134, 0, 0}// 79	80	81	
			, {3512, -133, 0, 0}, {3512, -132, 0, 0}, {3512, -131, 0, 0}// 82	83	84	
			, {3512, -130, 0, 0}, {3512, -140, 0, 0}, {3512, -139, 0, 0}// 85	86	87	
			, {3512, -138, 0, 0}, {3512, -137, 0, 0}, {3512, -142, 0, 0}// 88	89	90	
			, {3512, -141, 0, 0}, {3512, -145, 0, 0}, {3512, -144, 0, 0}// 91	92	93	
			, {3512, -143, 0, 0}, {3512, -126, 0, 0}, {3512, -125, 0, 0}// 94	95	96	
			, {3512, -124, 0, 0}, {3512, -123, 0, 0}, {3512, -122, 0, 0}// 97	98	99	
			, {3512, -121, 0, 0}, {3512, -120, 0, 0}, {3512, -119, 0, 0}// 100	101	102	
			, {3512, -118, 0, 0}, {3512, -117, 0, 0}, {3512, -116, 0, 0}// 103	104	105	
			, {3512, -115, 0, 0}, {3512, -114, 0, 0}, {3512, -127, 0, 0}// 106	107	108	
			, {3512, -128, 0, 0}, {3512, -129, 0, 0}, {3512, -113, 0, 0}// 109	110	111	
			, {3512, -112, 0, 0}, {3512, -111, 0, 0}, {3512, -110, 0, 0}// 112	113	114	
			, {3512, -106, 0, 0}, {3512, -105, 0, 0}, {3512, -104, 0, 0}// 115	116	117	
			, {3512, -103, 0, 0}, {3512, -102, 0, 0}, {3512, -101, 0, 0}// 118	119	120	
			, {3512, -100, 0, 0}, {3512, -99, 0, 0}, {3512, -98, 0, 0}// 121	122	123	
			, {3512, -83, 0, 0}, {3512, -82, 0, 0}, {3512, -89, 0, 0}// 124	125	126	
			, {3512, -88, 0, 0}, {3512, -87, 0, 0}, {3512, -86, 0, 0}// 127	128	129	
			, {3512, -85, 0, 0}, {3512, -84, 0, 0}, {3512, -97, 0, 0}// 130	131	132	
			, {3512, -96, 0, 0}, {3512, -95, 0, 0}, {3512, -94, 0, 0}// 133	134	135	
			, {3512, -93, 0, 0}, {3512, -92, 0, 0}, {3512, -91, 0, 0}// 136	137	138	
			, {3512, -90, 0, 0}, {3512, -69, 0, 0}, {3512, -66, 0, 0}// 139	140	141	
			, {3512, -76, 0, 0}, {3512, -75, 0, 0}, {3512, -74, 0, 0}// 142	143	144	
			, {3512, -73, 0, 0}, {3512, -79, 0, 0}, {3512, -78, 0, 0}// 145	146	147	
			, {3512, -77, 0, 0}, {3512, -81, 0, 0}, {3512, -80, 0, 0}// 148	149	150	
			, {3512, -67, 0, 0}, {3512, -68, 0, 0}, {3512, -72, 0, 0}// 151	152	153	
			, {3512, -71, 0, 0}, {3512, -70, 0, 0}, {3512, -53, 0, 0}// 154	155	156	
			, {3512, -50, 0, 0}, {3512, -51, 0, 0}, {3512, -52, 0, 0}// 157	158	159	
			, {3512, -59, 0, 0}, {3512, -60, 0, 0}, {3512, -58, 0, 0}// 160	161	162	
			, {3512, -57, 0, 0}, {3512, -56, 0, 0}, {3512, -55, 0, 0}// 163	164	165	
			, {3512, -54, 0, 0}, {3512, -64, 0, 0}, {3512, -63, 0, 0}// 166	167	168	
			, {3512, -62, 0, 0}, {3512, -61, 0, 0}, {3512, -65, 0, 0}// 169	170	171	
			, {3512, -49, 0, 0}, {3512, -42, 0, 0}, {3512, -38, 0, 0}// 172	173	174	
			, {3512, -43, 0, 0}, {3512, -47, 0, 0}, {3512, -45, 0, 0}// 175	176	177	
			, {3512, -44, 0, 0}, {3512, -37, 0, 0}, {3512, -46, 0, 0}// 178	179	180	
			, {3512, -48, 0, 0}, {3512, -34, 0, 0}, {3512, -35, 0, 0}// 181	182	183	
			, {3512, -36, 0, 0}, {3512, -23, 0, 0}, {3512, -21, 0, 0}// 184	185	186	
			, {3512, -29, 0, 0}, {3512, -25, 0, 0}, {3512, -27, 0, 0}// 187	188	189	
			, {3512, -20, 0, 0}, {3512, -24, 0, 0}, {3512, -18, 0, 0}// 190	191	192	
			, {3512, -32, 0, 0}, {3512, -28, 0, 0}, {3512, -26, 0, 0}// 193	194	195	
			, {3512, -30, 0, 0}, {3512, -33, 0, 0}, {3512, -19, 0, 0}// 196	197	198	
			, {3512, -22, 0, 0}, {3512, -31, 0, 0}, {3512, -11, 0, 0}// 199	200	201	
			, {3512, -3, 0, 0}, {3512, -17, 0, 0}, {3512, -5, 0, 0}// 202	203	204	
			, {3512, -9, 0, 0}, {3512, -6, 0, 0}, {3512, -7, 0, 0}// 205	206	207	
			, {3512, -4, 0, 0}, {3512, -14, 0, 0}, {3512, -13, 0, 0}// 208	209	210	
			, {3512, -12, 0, 0}, {3512, -16, 0, 0}, {3512, -15, 0, 0}// 211	212	213	
			, {3512, -8, 0, 0}, {3512, -10, 0, 0}, {3512, -2, 0, 0}// 214	215	216	
			, {3512, 1, 0, 0}, {3512, 2, 0, 0}, {3512, 14, 0, 0}// 217	218	219	
			, {3512, 11, 0, 0}, {3512, 9, 0, 0}, {3512, 12, 0, 0}// 220	221	222	
			, {3512, 5, 0, 0}, {3512, 10, 0, 0}, {3512, 0, 0, 0}// 223	224	225	
			, {3512, 3, 0, 0}, {3512, 4, 0, 0}, {3512, 8, 0, 0}// 226	227	228	
			, {3512, 13, 0, 0}, {3512, 6, 0, 0}, {3512, 7, 0, 0}// 229	230	231	
			, {3512, -1, 0, 0}, {3512, 26, 0, 0}, {3512, 23, 0, 0}// 232	233	234	
			, {3512, 21, 0, 0}, {3512, 22, 0, 0}, {3512, 15, 0, 0}// 235	236	237	
			, {3512, 18, 0, 0}, {3512, 30, 0, 0}, {3512, 19, 0, 0}// 238	239	240	
			, {3512, 16, 0, 0}, {3512, 25, 0, 0}, {3512, 20, 0, 0}// 241	242	243	
			, {3512, 24, 0, 0}, {3512, 17, 0, 0}, {3512, 39, 0, 0}// 244	245	246	
			, {3512, 35, 0, 0}, {3512, 38, 0, 0}, {3512, 41, 0, 0}// 247	248	249	
			, {3512, 42, 0, 0}, {3512, 40, 0, 0}, {3512, 43, 0, 0}// 250	251	252	
			, {3512, 32, 0, 0}, {3512, 37, 0, 0}, {3512, 45, 0, 0}// 253	254	255	
			, {3512, 33, 0, 0}, {3512, 44, 0, 0}, {3512, 31, 0, 0}// 256	257	258	
			, {3512, 34, 0, 0}, {3512, 36, 0, 0}, {3512, 46, 0, 0}// 259	260	261	
			, {3512, 54, 0, 0}, {3512, 59, 0, 0}, {3512, 52, 0, 0}// 262	263	264	
			, {3512, 48, 0, 0}, {3512, 49, 0, 0}, {3512, 55, 0, 0}// 265	266	267	
			, {3512, 57, 0, 0}, {3512, 53, 0, 0}, {3512, 50, 0, 0}// 268	269	270	
			, {3512, 51, 0, 0}, {3512, 61, 0, 0}, {3512, 58, 0, 0}// 271	272	273	
			, {3512, 62, 0, 0}, {3512, 56, 0, 0}, {3512, 60, 0, 0}// 274	275	276	
			, {3512, 47, 0, 0}, {3512, 71, 0, 0}, {3512, 64, 0, 0}// 277	278	279	
			, {3512, 67, 0, 0}, {3512, 76, 0, 0}, {3512, 77, 0, 0}// 280	281	282	
			, {3512, 68, 0, 0}, {3512, 72, 0, 0}, {3512, 69, 0, 0}// 283	284	285	
			, {3512, 78, 0, 0}, {3512, 63, 0, 0}, {3512, 66, 0, 0}// 286	287	288	
			, {3512, 70, 0, 0}, {3512, 73, 0, 0}, {3512, 75, 0, 0}// 289	290	291	
			, {3512, 74, 0, 0}, {3512, 65, 0, 0}, {3512, 84, 0, 0}// 292	293	294	
			, {3512, 90, 0, 0}, {3512, 82, 0, 0}, {3512, 83, 0, 0}// 295	296	297	
			, {3512, 87, 0, 0}, {3512, 88, 0, 0}, {3512, 89, 0, 0}// 298	299	300	
			, {3512, 86, 0, 0}, {3512, 81, 0, 0}, {3512, 94, 0, 0}// 301	302	303	
			, {3512, 91, 0, 0}, {3512, 92, 0, 0}, {3512, 93, 0, 0}// 304	305	306	
			, {3512, 79, 0, 0}, {3512, 80, 0, 0}, {3512, 85, 0, 0}// 307	308	309	
			, {3512, 101, 0, 0}, {3512, 103, 0, 0}, {3512, 104, 0, 0}// 310	311	312	
			, {3512, 110, 0, 0}, {3512, 99, 0, 0}, {3512, 102, 0, 0}// 313	314	315	
			, {3512, 105, 0, 0}, {3512, 109, 0, 0}, {3512, 100, 0, 0}// 316	317	318	
			, {3512, 98, 0, 0}, {3512, 107, 0, 0}, {3512, 108, 0, 0}// 319	320	321	
			, {3512, 106, 0, 0}, {3512, 126, 0, 0}, {3512, 118, 0, 0}// 322	323	324	
			, {3512, 116, 0, 0}, {3512, 112, 0, 0}, {3512, 119, 0, 0}// 325	326	327	
			, {3512, 113, 0, 0}, {3512, 124, 0, 0}, {3512, 111, 0, 0}// 328	329	330	
			, {3512, 125, 0, 0}, {3512, 121, 0, 0}, {3512, 117, 0, 0}// 331	332	333	
			, {3512, 123, 0, 0}, {3512, 114, 0, 0}, {3512, 122, 0, 0}// 334	335	336	
			, {3512, 120, 0, 0}, {3512, 115, 0, 0}, {3512, 127, 0, 0}// 337	338	339	
			, {3512, 128, 0, 0}, {3512, 132, 0, 0}, {3512, 133, 0, 0}// 340	341	342	
			, {3512, 134, 0, 0}, {3512, 135, 0, 0}, {3512, 136, 0, 0}// 343	344	345	
			, {3512, 137, 0, 0}, {3512, 138, 0, 0}, {3512, 139, 0, 0}// 346	347	348	
			, {3512, 140, 0, 0}, {3512, 141, 0, 0}, {3512, 142, 0, 0}// 349	350	351	
			, {3512, 130, 0, 0}, {3512, 129, 0, 0}, {3512, 131, 0, 0}// 352	353	354	
			, {3512, 143, 0, 0}, {3512, 144, 0, 0}, {3512, 145, 0, 0}// 355	356	357	
			, {3512, 146, 0, 0}, {3512, 147, 0, 0}, {3512, 148, 0, 0}// 358	359	360	
			, {3512, 149, 0, 0}, {3512, 150, 0, 0}, {3512, 151, 0, 0}// 361	362	363	
			, {3512, 152, 0, 0}, {3512, 153, 0, 0}, {3512, 154, 0, 0}// 364	365	366	
			, {3512, 155, 0, 0}, {3512, 156, 0, 0}, {3512, 157, 0, 0}// 367	368	369	
			, {3512, 158, 0, 0}, {3512, 171, 0, 0}, {3512, 169, 0, 0}// 370	371	372	
			, {3512, 162, 0, 0}, {3512, 170, 0, 0}, {3512, 161, 0, 0}// 373	374	375	
			, {3512, 168, 0, 0}, {3512, 167, 0, 0}, {3512, 159, 0, 0}// 376	377	378	
			, {3512, 173, 0, 0}, {3512, 172, 0, 0}, {3512, 160, 0, 0}// 379	380	381	
			, {3512, 166, 0, 0}, {3512, 174, 0, 0}, {3512, 179, 0, 0}// 382	383	384	
			, {3512, 176, 0, 0}, {3512, 178, 0, 0}, {3512, 175, 0, 0}// 385	386	387	
			, {3512, 184, 0, 0}, {3512, 182, 0, 0}, {3512, 177, 0, 0}// 388	389	390	
			, {3512, 189, 0, 0}, {3512, 185, 0, 0}, {3512, 186, 0, 0}// 391	392	393	
			, {3512, 183, 0, 0}, {3512, 181, 0, 0}, {3512, 180, 0, 0}// 394	395	396	
			, {3512, 188, 0, 0}, {3512, 190, 0, 0}, {3512, 187, 0, 0}// 397	398	399	
			, {3512, 196, 0, 0}, {3512, 200, 0, 0}, {3512, 197, 0, 0}// 400	401	402	
			, {3512, 204, 0, 0}, {3512, 203, 0, 0}, {3512, 199, 0, 0}// 403	404	405	
			, {3512, 201, 0, 0}, {3512, 194, 0, 0}, {3512, 193, 0, 0}// 406	407	408	
			, {3512, 195, 0, 0}, {3512, 191, 0, 0}, {3512, 206, 0, 0}// 409	410	411	
			, {3512, 192, 0, 0}, {3512, 205, 0, 0}, {3512, 202, 0, 0}// 412	413	414	
			, {3512, 198, 0, 0}, {3512, 220, 0, 0}, {3512, 209, 0, 0}// 415	416	417	
			, {3512, 221, 0, 0}, {3512, 210, 0, 0}, {3512, 207, 0, 0}// 418	419	420	
			, {3512, 215, 0, 0}, {3512, 222, 0, 0}, {3512, 214, 0, 0}// 421	422	423	
			, {3512, 213, 0, 0}, {3512, 212, 0, 0}, {3512, 219, 0, 0}// 424	425	426	
			, {3512, 218, 0, 0}, {3512, 211, 0, 0}, {3512, 217, 0, 0}// 427	428	429	
			, {3512, 208, 0, 0}, {3512, 216, 0, 0}, {3512, 226, 0, 0}// 430	431	432	
			, {3512, 223, 0, 0}, {3512, 224, 0, 0}, {3512, 225, 0, 0}// 433	434	435	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new eightyeighthedgelineguildhouseAddonDeed();
			}
		}

		[ Constructable ]
		public eightyeighthedgelineguildhouseAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public eightyeighthedgelineguildhouseAddon( Serial serial ) : base( serial )
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

	public class eightyeighthedgelineguildhouseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new eightyeighthedgelineguildhouseAddon();
			}
		}

		[Constructable]
		public eightyeighthedgelineguildhouseAddonDeed()
		{
			Name = "eightyeighthedgelineguildhouse";
		}

		public eightyeighthedgelineguildhouseAddonDeed( Serial serial ) : base( serial )
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