
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
	public class darkstonecraftshopWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1928, -7, -5, 0}, {1928, -7, -4, 0}, {1928, -7, -3, 0}// 1	2	3	
			, {1928, -7, -2, 0}, {1928, -7, -1, 0}, {1928, -7, 0, 0}// 4	5	6	
			, {1928, -6, -5, 0}, {1928, -6, -4, 0}, {1928, -6, -3, 0}// 7	8	9	
			, {1928, -6, -2, 0}, {1928, -6, -1, 0}, {1928, -6, 0, 0}// 10	11	12	
			, {1928, -5, -5, 1}, {1928, -5, -4, 0}, {1928, -5, -3, 0}// 13	14	15	
			, {1928, -5, -2, 0}, {1928, -5, -1, 0}, {1928, -5, 0, 0}// 16	17	18	
			, {1928, -4, -5, 0}, {1928, -4, -4, 0}, {1928, -4, -3, 0}// 19	20	21	
			, {1928, -4, -2, 0}, {1928, -4, -1, 0}, {1928, -4, 0, 0}// 22	23	24	
			, {1928, -3, -5, 0}, {1928, -3, -4, 0}, {1928, -3, -3, 0}// 25	26	27	
			, {1928, -3, -2, 0}, {1928, -3, -1, 0}, {1928, -3, 0, 0}// 28	29	30	
			, {1928, -2, -5, 0}, {1928, -2, -4, 0}, {1928, -2, -3, 0}// 31	32	33	
			, {1928, -2, -2, 0}, {1928, -2, -1, 0}, {1928, -2, 0, 0}// 34	35	36	
			, {1928, -1, -5, 0}, {1928, -1, -4, 0}, {1928, -1, -3, 0}// 37	38	39	
			, {1928, -1, -2, 0}, {1928, -1, -1, 0}, {1928, -1, 0, 0}// 40	41	42	
			, {1928, 0, -5, 0}, {1928, 0, -4, 0}, {1928, 0, -3, 0}// 43	44	45	
			, {1928, 0, -2, 0}, {1928, 0, -1, 0}, {1928, 0, 0, 0}// 46	47	48	
			, {1928, 1, -3, 0}, {1928, 1, -2, 0}, {1928, 1, -1, 0}// 49	50	51	
			, {1928, 1, 0, 0}, {1928, 2, -5, 0}, {1928, 2, -4, 0}// 52	53	54	
			, {1928, 2, -3, 0}, {1928, 2, -2, 0}, {1928, 2, -1, 0}// 55	56	57	
			, {1928, 2, 0, 0}, {1928, 3, -5, 0}, {1928, 3, -4, 0}// 58	59	60	
			, {1928, 3, -3, 0}, {1928, 3, -2, 0}, {1928, 3, -1, 0}// 61	62	63	
			, {1928, 3, 0, 0}, {1928, 4, -5, 0}, {1928, 4, -4, 0}// 64	65	66	
			, {1928, 4, -3, 0}, {1928, 4, -2, 0}, {1928, 4, -1, 0}// 67	68	69	
			, {1928, 4, 0, 0}, {1928, 5, -5, 0}, {1928, 5, -4, 0}// 70	71	72	
			, {1928, 5, -3, 0}, {1928, 5, -2, 0}, {1928, 5, -1, 0}// 73	74	75	
			, {1928, 5, 0, 0}, {1928, 6, -5, 0}, {1928, 6, -4, 0}// 76	77	78	
			, {1928, 6, -3, 0}, {1928, 6, -2, 0}, {1928, 6, -1, 0}// 79	80	81	
			, {1928, 6, 0, 0}, {1931, -7, -6, 0}, {1931, -6, -6, 0}// 82	83	84	
			, {1931, -5, -6, 0}, {1931, -4, -6, 0}, {1931, -3, -6, 0}// 85	86	87	
			, {1931, -2, -6, 0}, {1931, -1, -6, 0}, {1931, 0, -6, 0}// 88	89	90	
			, {1931, 1, -6, 0}, {1931, 2, -6, 0}, {1931, 3, -6, 0}// 91	92	93	
			, {1931, 4, -6, 0}, {1931, 5, -6, 0}, {1931, 6, -6, 0}// 94	95	96	
			, {1932, -8, -5, 0}, {1932, -8, -4, 0}, {1932, -8, -3, 0}// 97	98	99	
			, {1932, -8, -2, 0}, {1932, -8, -1, 0}, {1932, -8, 0, 0}// 100	101	102	
			, {1933, -8, -6, 0}, {466, -7, -5, 5}, {6539, -6, -1, 5}// 103	104	105	
			, {6537, -6, -2, 5}, {7147, -6, -3, 5}, {7159, -6, -3, 7}// 106	107	108	
			, {7141, -6, -3, 9}, {7153, -6, -3, 11}, {4022, -5, -2, 5}// 109	110	111	
			, {4020, -5, -1, 5}, {4028, -5, 0, 5}, {6551, -6, 0, 5}// 112	113	114	
			, {7138, 0, -5, 5}, {7612, -1, -3, 5}, {7613, -1, -2, 5}// 115	116	117	
			, {7613, -1, -1, 5}, {7613, -1, 0, 5}, {7159, -3, -2, 5}// 118	119	120	
			, {4021, -1, -3, 11}, {7147, -3, 0, 5}, {7141, -3, -1, 5}// 121	122	123	
			, {4027, -1, -1, 11}, {4216, 0, -3, 5}, {4223, 6, -4, 5}// 124	125	126	
			, {4596, 6, -3, 5}, {4599, 6, -2, 5}, {9552, 1, -5, 5}// 127	128	134	
			, {1928, 1, -4, 0}, {1928, 1, -5, 0}, {2602, -5, 0, 5}// 135	136	137	
			, {1313, -7, -5, 25}, {1313, -7, -4, 25}, {1313, -7, -3, 25}// 138	139	140	
			, {1313, -7, -2, 25}, {1313, -7, -1, 25}, {1313, -7, 0, 25}// 141	142	143	
			, {1313, -6, -5, 25}, {1313, -6, -3, 25}, {1313, -6, -2, 25}// 144	145	146	
			, {1313, -6, -1, 25}, {1313, -6, 0, 25}, {1313, -5, -5, 25}// 147	148	149	
			, {1313, -5, -3, 25}, {1313, -5, -2, 25}, {1313, -5, -1, 25}// 150	151	152	
			, {1313, -5, 0, 25}, {1313, -4, -5, 25}, {1313, -4, -4, 25}// 153	154	155	
			, {1313, -4, -3, 25}, {1313, -4, -2, 25}, {1313, -4, -1, 25}// 156	157	158	
			, {1313, -4, 0, 25}, {1313, -3, -5, 25}, {1313, -3, -4, 25}// 159	160	161	
			, {1313, -3, -3, 25}, {1313, -3, -2, 25}, {1313, -3, -1, 25}// 162	163	164	
			, {1313, -3, 0, 25}, {1313, -2, -5, 25}, {1313, -2, -4, 25}// 165	166	167	
			, {1313, -2, -3, 25}, {1313, -2, -2, 25}, {1313, -2, -1, 25}// 168	169	170	
			, {1313, -2, 0, 25}, {1313, -1, -5, 25}, {1313, -1, -4, 25}// 171	172	173	
			, {1313, -1, -3, 25}, {1313, -1, -2, 25}, {1313, -1, -1, 25}// 174	175	176	
			, {1313, -1, 0, 25}, {1313, 0, -5, 25}, {1313, 0, -4, 25}// 177	178	179	
			, {1313, 0, -3, 25}, {1313, 0, -2, 25}, {1313, 0, -1, 25}// 180	181	182	
			, {1313, 0, 0, 25}, {1313, 1, -5, 25}, {1313, 1, -4, 25}// 183	184	185	
			, {1313, 1, -3, 25}, {1313, 1, -2, 25}, {1313, 1, -1, 25}// 186	187	188	
			, {1313, 1, 0, 25}, {1313, 2, -5, 25}, {1313, 2, -4, 25}// 189	190	191	
			, {1313, 2, -3, 25}, {1313, 2, -2, 25}, {1313, 2, -1, 25}// 192	193	194	
			, {1313, 2, 0, 25}, {1313, 3, -5, 25}, {1313, 3, -4, 25}// 195	196	197	
			, {1313, 3, -3, 25}, {1313, 3, -2, 25}, {1313, 3, -1, 25}// 198	199	200	
			, {1313, 3, 0, 25}, {1313, 4, -5, 25}, {1313, 4, -4, 25}// 201	202	203	
			, {1313, 4, -3, 25}, {1313, 4, -2, 25}, {1313, 4, -1, 25}// 204	205	206	
			, {1313, 4, 0, 25}, {1313, 5, -5, 25}, {1313, 5, -4, 25}// 207	208	209	
			, {1313, 5, -3, 25}, {1313, 5, -2, 25}, {1313, 5, -1, 25}// 210	211	212	
			, {1313, 5, 0, 25}, {1313, 6, -5, 25}, {1313, 6, -4, 25}// 213	214	215	
			, {1313, 6, -3, 25}, {1313, 6, -2, 25}, {1313, 6, -1, 25}// 216	217	218	
			, {1313, 6, 0, 25}, {7867, -1, 0, 11}, {489, -7, -6, 25}// 219	220	221	
			, {489, -6, -6, 25}, {489, -5, -6, 25}, {489, -4, -6, 25}// 222	223	224	
			, {489, -3, -6, 25}, {489, -2, -6, 25}, {489, -1, -6, 25}// 225	226	227	
			, {489, 0, -6, 25}, {489, 1, -6, 25}, {489, 2, -6, 25}// 228	229	230	
			, {489, 3, -6, 25}, {489, 4, -6, 25}, {489, 5, -6, 25}// 231	232	233	
			, {489, 6, -6, 25}, {490, -8, -5, 25}, {490, -8, -4, 25}// 234	235	236	
			, {490, -8, -3, 25}, {490, -8, -2, 25}, {490, -8, -1, 25}// 237	238	239	
			, {490, -8, 0, 25}, {491, -8, -6, 25}, {1313, -5, -4, 25}// 240	241	242	
			, {1313, -6, -4, 25}, {1928, -7, 1, 0}, {1928, -7, 2, 0}// 243	244	245	
			, {1928, -7, 3, 0}, {1928, -7, 4, 0}, {1928, -6, 1, 0}// 246	247	248	
			, {1928, -6, 2, 0}, {1928, -6, 3, 0}, {1928, -6, 4, 0}// 249	250	251	
			, {1928, -5, 1, 0}, {1928, -5, 2, 0}, {1928, -5, 3, 0}// 252	253	254	
			, {1928, -5, 4, 0}, {1928, -4, 1, 0}, {1928, -4, 2, 0}// 255	256	257	
			, {1928, -4, 3, 0}, {1928, -4, 4, 0}, {1928, -3, 1, 0}// 258	259	260	
			, {1928, -3, 2, 0}, {1928, -3, 3, 0}, {1928, -3, 4, 0}// 261	262	263	
			, {1928, -2, 1, 0}, {1928, -2, 2, 0}, {1928, -2, 3, 0}// 264	265	266	
			, {1928, -2, 4, 0}, {1928, -1, 1, 0}, {1928, -1, 2, 0}// 267	268	269	
			, {1928, -1, 3, 0}, {1928, -1, 4, 0}, {1928, 0, 1, 0}// 270	271	272	
			, {1928, 0, 2, 0}, {1928, 0, 3, 0}, {1928, 0, 4, 0}// 273	274	275	
			, {1928, 1, 1, 0}, {1928, 1, 2, 0}, {1928, 1, 3, 0}// 276	277	278	
			, {1928, 1, 4, 0}, {1928, 2, 1, 0}, {1928, 2, 2, 0}// 279	280	281	
			, {1928, 2, 3, 0}, {1928, 3, 1, 0}, {1928, 3, 2, 0}// 282	283	284	
			, {1928, 3, 3, 0}, {1928, 3, 4, 0}, {1928, 4, 1, 0}// 285	286	287	
			, {1928, 4, 2, 0}, {1928, 4, 3, 0}, {1928, 4, 4, 0}// 288	289	290	
			, {1928, 5, 1, 0}, {1928, 5, 2, 0}, {1928, 5, 3, 0}// 291	292	293	
			, {1928, 5, 4, 0}, {1928, 6, 1, 0}, {1928, 6, 2, 0}// 294	295	296	
			, {1928, 6, 3, 0}, {1928, 6, 4, 0}, {1929, -7, 5, 0}// 297	298	299	
			, {1929, -6, 5, 0}, {1929, -5, 5, 0}, {1929, -4, 5, 0}// 300	301	302	
			, {1929, -3, 5, 0}, {1929, -2, 5, 0}, {1929, -1, 5, 0}// 303	304	305	
			, {1929, 0, 5, 0}, {1929, 1, 5, 0}, {1929, 2, 5, 0}// 306	307	308	
			, {1929, 3, 5, 0}, {1929, 4, 5, 0}, {1929, 5, 5, 0}// 309	310	311	
			, {1929, 6, 5, 0}, {1932, -8, 1, 0}, {1932, -8, 2, 0}// 312	313	314	
			, {1932, -8, 3, 0}, {1932, -8, 4, 0}, {1936, -8, 5, 0}// 315	316	317	
			, {466, -7, 4, 4}, {4015, -6, 2, 5}, {5453, -5, 2, 5}// 318	319	320	
			, {6549, -6, 1, 5}, {4024, -5, 1, 5}, {6792, -5, 4, 5}// 321	322	323	
			, {7613, -1, 1, 5}, {7611, -1, 2, 5}, {7153, -3, 1, 5}// 324	325	326	
			, {7793, -2, 4, 5}, {7791, 5, 4, 5}, {6645, 3, 3, 5}// 327	328	329	
			, {6647, 1, 3, 5}, {6646, 2, 3, 5}, {5353, 2, 3, 8}// 330	331	332	
			, {7797, 1, 4, 5}, {6651, 3, 1, 5}, {6652, 4, 1, 5}// 333	334	335	
			, {9552, 0, 4, 5}, {1928, 2, 4, 0}, {1313, -7, 1, 25}// 337	338	339	
			, {1313, -7, 2, 25}, {1313, -7, 3, 25}, {1313, -7, 4, 25}// 340	341	342	
			, {1313, -6, 1, 25}, {1313, -6, 2, 25}, {1313, -6, 3, 25}// 343	344	345	
			, {1313, -6, 4, 25}, {1313, -5, 1, 25}, {1313, -5, 2, 25}// 346	347	348	
			, {1313, -5, 3, 25}, {1313, -5, 4, 25}, {1313, -4, 1, 25}// 349	350	351	
			, {1313, -4, 2, 25}, {1313, -4, 3, 25}, {1313, -4, 4, 25}// 352	353	354	
			, {1313, -3, 1, 25}, {1313, -3, 2, 25}, {1313, -3, 3, 25}// 355	356	357	
			, {1313, -3, 4, 25}, {1313, -2, 1, 25}, {1313, -2, 2, 25}// 358	359	360	
			, {1313, -2, 3, 25}, {1313, -2, 4, 25}, {1313, -1, 1, 25}// 361	362	363	
			, {1313, -1, 2, 25}, {1313, -1, 3, 25}, {1313, -1, 4, 25}// 364	365	366	
			, {1313, 0, 1, 25}, {1313, 0, 2, 25}, {1313, 0, 3, 25}// 367	368	369	
			, {1313, 0, 4, 25}, {1313, 1, 1, 25}, {1313, 1, 2, 25}// 370	371	372	
			, {1313, 1, 3, 25}, {1313, 1, 4, 25}, {1313, 2, 1, 25}// 373	374	375	
			, {1313, 2, 2, 25}, {1313, 2, 3, 25}, {1313, 2, 4, 25}// 376	377	378	
			, {1313, 3, 1, 25}, {1313, 3, 2, 25}, {1313, 3, 3, 25}// 379	380	381	
			, {1313, 3, 4, 25}, {1313, 4, 1, 25}, {1313, 4, 2, 25}// 382	383	384	
			, {1313, 4, 3, 25}, {1313, 4, 4, 25}, {1313, 5, 1, 25}// 385	386	387	
			, {1313, 5, 2, 25}, {1313, 5, 3, 25}, {1313, 5, 4, 25}// 388	389	390	
			, {1313, 6, 1, 25}, {1313, 6, 2, 25}, {1313, 6, 3, 25}// 391	392	393	
			, {1313, 6, 4, 25}, {489, -7, 4, 25}, {489, -5, 4, 25}// 394	395	396	
			, {489, -4, 4, 25}, {489, -3, 4, 25}, {489, -2, 4, 25}// 397	398	399	
			, {489, -1, 4, 25}, {489, 0, 4, 25}, {489, 1, 4, 25}// 400	401	402	
			, {489, 2, 4, 25}, {489, 3, 4, 25}, {489, 4, 4, 25}// 403	404	405	
			, {489, 5, 4, 25}, {489, 6, 4, 25}, {6264, -1, 1, 11}// 406	407	408	
			, {6265, -1, 2, 11}, {490, -8, 1, 25}, {490, -8, 2, 25}// 409	410	411	
			, {490, -8, 3, 25}, {490, -8, 4, 25}, {2212, -6, 6, 1}// 412	413	414	
			, {2210, -6, 5, 13}, {1928, 7, -5, 0}, {1928, 7, -4, 0}// 415	416	417	
			, {1928, 7, -3, 0}, {1928, 7, -2, 0}, {1928, 7, -1, 0}// 418	419	420	
			, {1928, 7, 0, 0}, {1930, 8, -5, 0}, {1930, 8, -4, 0}// 421	422	423	
			, {1930, 8, -3, 0}, {1930, 8, -2, 0}, {1930, 8, -1, 0}// 424	425	426	
			, {1930, 8, 0, 0}, {1931, 7, -6, 0}, {1935, 8, -6, 0}// 427	428	429	
			, {466, 7, -5, 5}, {4224, 7, -4, 5}, {4011, 7, -1, 5}// 430	431	432	
			, {1279, 7, -5, 0}, {1279, 7, -4, 0}, {1279, 7, -3, 0}// 433	434	435	
			, {1279, 7, -2, 0}, {1279, 7, -1, 0}, {1279, 7, 0, 0}// 436	437	438	
			, {1313, 7, -5, 25}, {1313, 7, -4, 25}, {1313, 7, -3, 25}// 439	440	441	
			, {1313, 7, -2, 25}, {1313, 7, -1, 25}, {1313, 7, 0, 25}// 442	443	444	
			, {489, 7, -6, 25}, {490, 7, -5, 25}, {490, 7, -4, 25}// 445	446	447	
			, {490, 7, -3, 25}, {490, 7, -2, 25}, {490, 7, -1, 25}// 448	449	450	
			, {490, 7, 0, 25}, {4009, 7, 0, 5}, {1928, 7, 1, 0}// 451	452	453	
			, {1928, 7, 2, 0}, {1928, 7, 3, 0}, {1928, 7, 4, 0}// 454	455	456	
			, {1929, 7, 5, 0}, {1930, 8, 4, 0}, {1930, 8, 1, 0}// 457	458	459	
			, {1930, 8, 2, 0}, {1930, 8, 3, 0}, {1934, 8, 5, 0}// 460	461	462	
			, {7798, 7, 2, 5}, {1279, 7, 1, 0}, {1279, 7, 2, 0}// 463	464	465	
			, {1279, 7, 3, 0}, {1279, 7, 4, 0}, {9552, 7, 4, 5}// 466	467	468	
			, {1313, 7, 1, 25}, {1313, 7, 2, 25}, {1313, 7, 3, 25}// 469	470	471	
			, {1313, 7, 4, 25}, {488, 7, 4, 25}, {490, 7, 1, 25}// 472	473	474	
			, {490, 7, 2, 25}, {490, 7, 3, 25}// 475	476	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new darkstonecraftshopWEAddonDeed();
			}
		}

		[ Constructable ]
		public darkstonecraftshopWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5991, 0, 0, 5, 113, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 5991, 0, -1, 5, 39, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 3995, 2, -5, 5, 39, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 3996, 3, -5, 5, 57, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 3991, 4, -5, 5, 107, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 5991, 0, 1, 6, 76, -1, "", 1);// 336

		}

		public darkstonecraftshopWEAddon( Serial serial ) : base( serial )
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

	public class darkstonecraftshopWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new darkstonecraftshopWEAddon();
			}
		}

		[Constructable]
		public darkstonecraftshopWEAddonDeed()
		{
			Name = "darkstonecraftshopWE";
		}

		public darkstonecraftshopWEAddonDeed( Serial serial ) : base( serial )
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