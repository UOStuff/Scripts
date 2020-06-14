
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
	public class FourPlotSouthEastMoatAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6039, -20, 14, 0}, {6039, -19, 14, 0}, {6039, -18, 14, 0}// 1	2	3	
			, {6039, -17, 14, 0}, {6039, -16, 14, 0}, {6039, -15, 14, 0}// 4	5	6	
			, {6039, -14, 14, 0}, {6039, -13, 14, 0}, {6039, -12, 14, 0}// 7	8	9	
			, {6039, -11, 14, 0}, {6039, -10, 14, 0}, {6039, -9, 14, 0}// 10	11	12	
			, {6039, -8, 14, 0}, {6039, -7, 14, 0}, {6039, -20, 15, 0}// 13	14	15	
			, {6039, -18, 15, 0}, {6039, -17, 15, 0}, {6039, -16, 15, 0}// 16	17	18	
			, {6039, -15, 15, 0}, {6039, -14, 15, 0}, {6039, -13, 15, 0}// 19	20	21	
			, {6039, -12, 15, 0}, {6039, -11, 15, 0}, {6039, -10, 15, 0}// 22	23	24	
			, {6039, -9, 15, 0}, {6039, -8, 15, 0}, {6039, -7, 15, 0}// 25	26	27	
			, {6039, -20, 16, 0}, {6039, -20, 17, 0}, {6039, -20, 18, 0}// 28	29	30	
			, {6039, -19, 16, 0}, {6039, -19, 17, 0}, {6039, -19, 18, 0}// 31	32	33	
			, {6039, -19, 19, 0}, {6039, -18, 16, 0}, {6039, -18, 17, 0}// 34	35	36	
			, {6039, -18, 18, 0}, {6039, -18, 19, 0}, {6039, -18, 20, 0}// 37	38	39	
			, {6039, -17, 16, 0}, {6039, -17, 17, 0}, {6039, -17, 18, 0}// 40	41	42	
			, {6039, -17, 19, 0}, {6039, -17, 20, 0}, {6039, -16, 16, 0}// 43	44	45	
			, {6039, -16, 17, 0}, {6039, -15, 18, 0}, {6039, -16, 19, 0}// 46	47	48	
			, {6039, -16, 20, 0}, {6039, -15, 16, 0}, {6039, -15, 17, 0}// 49	50	51	
			, {6039, -14, 18, 0}, {6039, -15, 19, 0}, {6039, -15, 20, 0}// 52	53	54	
			, {6039, -14, 16, 0}, {6039, -14, 17, 0}, {6039, -14, 19, 0}// 55	56	57	
			, {6039, -14, 20, 0}, {6039, -13, 16, 0}, {6039, -13, 17, 0}// 58	59	60	
			, {6039, -13, 18, 0}, {6039, -13, 19, 0}, {6039, -13, 20, 0}// 61	62	63	
			, {6039, -12, 16, 0}, {6039, -12, 17, 0}, {6039, -12, 18, 0}// 64	65	66	
			, {6039, -12, 19, 0}, {6039, -12, 20, 0}, {6039, -10, 16, 0}// 67	68	69	
			, {6039, -11, 17, 0}, {6039, -11, 18, 0}, {6039, -11, 19, 0}// 70	71	72	
			, {6039, -11, 20, 0}, {6039, -9, 16, 0}, {6039, -10, 17, 0}// 73	74	75	
			, {6039, -10, 18, 0}, {6039, -10, 19, 0}, {6039, -10, 20, 0}// 76	77	78	
			, {6039, -9, 17, 0}, {6039, -9, 18, 0}, {6039, -9, 19, 0}// 79	80	81	
			, {6039, -9, 20, 0}, {6039, -8, 16, 0}, {6039, -8, 17, 0}// 82	83	84	
			, {6039, -8, 19, 0}, {6039, -7, 19, 0}, {6039, -8, 20, 0}// 85	86	87	
			, {6039, -7, 16, 0}, {6039, -7, 17, 0}, {6039, -7, 18, 0}// 88	89	90	
			, {6039, -7, 20, 0}, {6049, -18, 21, 0}, {6049, -16, 21, 0}// 91	92	93	
			, {6049, -14, 21, 0}, {6049, -12, 21, 0}, {6049, -10, 21, 0}// 94	95	96	
			, {6049, -8, 21, 0}, {6050, -17, 21, 0}, {6050, -15, 21, 0}// 97	98	99	
			, {6050, -13, 21, 0}, {6050, -11, 21, 0}, {6050, -9, 21, 0}// 100	101	102	
			, {6050, -7, 21, 0}, {6059, -20, 19, 0}, {6059, -19, 20, 0}// 103	104	105	
			, {6064, -19, 21, 0}, {6064, -20, 20, 0}, {6064, -21, 19, 0}// 106	107	108	
			, {6052, -21, 18, 0}, {6052, -21, 16, 0}, {6052, -21, 14, 0}// 109	110	111	
			, {6051, -21, 17, 0}, {6051, -21, 15, 0}, {13456, -19, 15, 0}// 112	113	114	
			, {13456, -16, 18, 0}, {13456, -11, 16, 0}, {3207, -17, 21, 0}// 115	116	117	
			, {3235, -16, 21, 0}, {3518, -14, 16, 1}, {3339, -7, 19, 1}// 118	119	120	
			, {13456, -8, 18, 0}, {3237, -21, 16, 0}, {3237, -20, 20, 0}// 121	122	123	
			, {3262, -11, 21, 0}, {3514, -12, 18, 0}, {3514, -18, 16, 0}// 124	125	126	
			, {3208, -7, 21, 0}, {3157, -8, 20, 0}, {3157, -9, 21, 0}// 127	128	129	
			, {3157, -8, 21, 0}, {3157, -12, 14, 0}, {3157, -11, 14, 0}// 130	131	132	
			, {3157, -11, 15, 0}, {3211, -13, 21, 0}, {3332, -9, 14, 0}// 133	134	135	
			, {3332, -17, 14, 0}, {3157, -19, 20, 0}, {3157, -18, 21, 0}// 136	137	138	
			, {3157, -18, 20, 0}, {6039, -6, 15, 0}, {6039, -5, 15, 0}// 139	140	141	
			, {6039, -4, 15, 0}, {6039, -3, 15, 0}, {6039, -2, 15, 0}// 142	143	144	
			, {6039, 0, 15, 0}, {6039, 1, 15, 0}, {6039, 2, 15, 0}// 145	146	147	
			, {6039, 4, 15, 0}, {6039, 5, 15, 0}, {6039, 6, 15, 0}// 148	149	150	
			, {6039, 7, 15, 0}, {6039, 8, 15, 0}, {6039, 0, 14, 0}// 151	152	153	
			, {6039, 1, 14, 0}, {6039, 2, 14, 0}, {6039, 3, 14, 0}// 154	155	156	
			, {6039, 4, 14, 0}, {6039, 5, 14, 0}, {6039, 6, 14, 0}// 157	158	159	
			, {6039, 7, 14, 0}, {6039, 8, 14, 0}, {6039, 9, 14, 0}// 160	161	162	
			, {6039, -6, 16, 0}, {6039, -6, 17, 0}, {6039, -6, 18, 0}// 163	164	165	
			, {6039, -6, 19, 0}, {6039, -6, 20, 0}, {6039, -5, 16, 0}// 166	167	168	
			, {6039, -5, 17, 0}, {6039, -5, 18, 0}, {6039, -5, 19, 0}// 169	170	171	
			, {6039, -5, 20, 0}, {6039, -4, 16, 0}, {6039, -4, 17, 0}// 172	173	174	
			, {6039, -4, 18, 0}, {6039, -4, 19, 0}, {6039, -4, 20, 0}// 175	176	177	
			, {6039, -3, 16, 0}, {6039, -3, 17, 0}, {6039, -3, 18, 0}// 178	179	180	
			, {6039, -3, 19, 0}, {6039, -3, 20, 0}, {6039, -2, 16, 0}// 181	182	183	
			, {6039, -2, 17, 0}, {6039, -2, 18, 0}, {6039, -2, 19, 0}// 184	185	186	
			, {6039, -2, 20, 0}, {6039, 0, 16, 0}, {6039, 0, 17, 0}// 187	188	189	
			, {6039, 0, 18, 0}, {6039, 0, 20, 0}, {6039, 1, 16, 0}// 190	191	192	
			, {6039, 1, 17, 0}, {6039, 1, 18, 0}, {6039, 1, 19, 0}// 193	194	195	
			, {6039, 1, 20, 0}, {6039, 2, 16, 0}, {6039, 2, 17, 0}// 196	197	198	
			, {6039, 2, 18, 0}, {6039, 2, 19, 0}, {6039, 2, 20, 0}// 199	200	201	
			, {6039, 3, 16, 0}, {6039, 3, 17, 0}, {6039, 3, 18, 0}// 202	203	204	
			, {6039, 3, 19, 0}, {6039, 3, 20, 0}, {6039, 4, 16, 0}// 205	206	207	
			, {6039, 4, 17, 0}, {6039, 4, 18, 0}, {6039, 4, 19, 0}// 208	209	210	
			, {6039, 4, 20, 0}, {6039, 5, 16, 0}, {6039, 5, 17, 0}// 211	212	213	
			, {6039, 5, 18, 0}, {6039, 5, 19, 0}, {6039, 5, 20, 0}// 214	215	216	
			, {6039, 6, 16, 0}, {6039, 6, 17, 0}, {6039, 6, 18, 0}// 217	218	219	
			, {6039, 6, 20, 0}, {6039, 7, 16, 0}, {6039, 7, 17, 0}// 220	221	222	
			, {6039, 7, 18, 0}, {6039, 7, 19, 0}, {6039, 7, 20, 0}// 223	224	225	
			, {6039, 8, 16, 0}, {6039, 8, 17, 0}, {6039, 8, 18, 0}// 226	227	228	
			, {6039, 8, 19, 0}, {6039, 8, 20, 0}, {6039, 9, 16, 0}// 229	230	231	
			, {6039, 9, 17, 0}, {6039, 9, 18, 0}, {6039, 9, 19, 0}// 232	233	234	
			, {6039, 9, 20, 0}, {6049, -6, 21, 0}, {6049, -4, 21, 0}// 235	236	237	
			, {6049, -2, 21, 0}, {6049, 0, 21, 0}, {6049, 2, 21, 0}// 238	239	240	
			, {6049, 4, 21, 0}, {6049, 6, 21, 0}, {6049, 8, 21, 0}// 241	242	243	
			, {6050, -5, 21, 0}, {6050, -3, 21, 0}, {6050, 1, 21, 0}// 244	245	246	
			, {6050, 3, 21, 0}, {6050, 5, 21, 0}, {6050, 7, 21, 0}// 247	248	249	
			, {6050, 9, 21, 0}, {13456, 9, 15, 0}, {13456, 3, 15, 0}// 250	251	252	
			, {13456, 6, 19, 0}, {13456, 0, 19, 0}, {6039, -6, 14, 0}// 253	254	255	
			, {6039, -5, 14, 0}, {6039, -4, 14, 0}, {6039, -3, 14, 0}// 256	257	258	
			, {6039, -2, 14, 0}, {3518, 3, 18, 1}, {6039, -1, 14, 0}// 259	260	261	
			, {6039, -1, 15, 0}, {6039, -1, 16, 0}, {6039, -1, 17, 0}// 262	263	264	
			, {6039, -1, 18, 0}, {6039, -1, 19, 0}, {6039, -1, 20, 0}// 265	266	267	
			, {6050, -1, 21, 0}, {3515, 7, 17, 0}, {3208, 3, 21, 0}// 268	269	270	
			, {3157, 4, 21, 0}, {3157, 5, 20, 0}, {3157, 5, 21, 0}// 271	272	273	
			, {3157, 9, 14, 0}, {3212, 9, 21, 0}, {3332, 4, 14, 0}// 274	275	276	
			, {6039, 14, -15, 0}, {6039, 14, -14, 0}, {6039, 14, -13, 0}// 277	278	279	
			, {6039, 14, -12, 0}, {6039, 14, -11, 0}, {6039, 14, -10, 0}// 280	281	282	
			, {6039, 15, -15, 0}, {6039, 15, -14, 0}, {6039, 15, -13, 0}// 283	284	285	
			, {6039, 15, -12, 0}, {6039, 15, -11, 0}, {6039, 15, -10, 0}// 286	287	288	
			, {6039, 16, -15, 0}, {6039, 16, -14, 0}, {6039, 16, -13, 0}// 289	290	291	
			, {6039, 16, -11, 0}, {6039, 16, -10, 0}, {6039, 17, -15, 0}// 292	293	294	
			, {6039, 17, -14, 0}, {6039, 17, -13, 0}, {6039, 17, -12, 0}// 295	296	297	
			, {6039, 17, -11, 0}, {6039, 17, -10, 0}, {6039, 18, -15, 0}// 298	299	300	
			, {6039, 18, -14, 0}, {6039, 18, -13, 0}, {6039, 18, -12, 0}// 301	302	303	
			, {6039, 18, -11, 0}, {6039, 18, -10, 0}, {6039, 19, -15, 0}// 304	305	306	
			, {6039, 19, -14, 0}, {6039, 19, -13, 0}, {6039, 19, -12, 0}// 307	308	309	
			, {6039, 19, -11, 0}, {6039, 19, -10, 0}, {6039, 20, -15, 0}// 310	311	312	
			, {6039, 20, -14, 0}, {6039, 20, -13, 0}, {6039, 20, -12, 0}// 313	314	315	
			, {6039, 20, -11, 0}, {6039, 20, -10, 0}, {6039, 14, -20, 0}// 316	317	318	
			, {6039, 14, -19, 0}, {6039, 14, -18, 0}, {6039, 14, -17, 0}// 319	320	321	
			, {6039, 14, -16, 0}, {6039, 15, -20, 0}, {6039, 15, -18, 0}// 322	323	324	
			, {6039, 15, -17, 0}, {6039, 15, -16, 0}, {6039, 16, -20, 0}// 325	326	327	
			, {6039, 16, -19, 0}, {6039, 16, -18, 0}, {6039, 16, -17, 0}// 328	329	330	
			, {6039, 16, -16, 0}, {6039, 17, -20, 0}, {6039, 17, -19, 0}// 331	332	333	
			, {6039, 17, -18, 0}, {6039, 17, -17, 0}, {6039, 17, -16, 0}// 334	335	336	
			, {6039, 18, -20, 0}, {6039, 18, -19, 0}, {6039, 18, -18, 0}// 337	338	339	
			, {6039, 18, -16, 0}, {6039, 19, -19, 0}, {6039, 19, -18, 0}// 340	341	342	
			, {6039, 19, -17, 0}, {6039, 19, -16, 0}, {6039, 20, -18, 0}// 343	344	345	
			, {6039, 20, -17, 0}, {6039, 20, -16, 0}, {6045, 21, -18, 0}// 346	347	348	
			, {6045, 21, -16, 0}, {6045, 21, -14, 0}, {6045, 21, -12, 0}// 349	350	351	
			, {6045, 21, -10, 0}, {6046, 21, -17, 0}, {6046, 21, -15, 0}// 352	353	354	
			, {6046, 21, -13, 0}, {6046, 21, -11, 0}, {6048, 14, -21, 0}// 355	356	357	
			, {6048, 16, -21, 0}, {6048, 18, -21, 0}, {6047, 15, -21, 0}// 358	359	360	
			, {6047, 17, -21, 0}, {6057, 20, -19, 0}, {6057, 19, -20, 0}// 361	362	363	
			, {6066, 21, -19, 0}, {6066, 20, -20, 0}, {6066, 19, -21, 0}// 364	365	366	
			, {13456, 15, -19, 0}, {13456, 18, -17, 0}, {13456, 16, -12, 0}// 367	368	369	
			, {3339, 15, -15, 1}, {3515, 19, -12, 0}, {3515, 17, -19, 0}// 370	371	372	
			, {3237, 14, -21, 0}, {3157, 14, -14, 0}, {3157, 14, -13, 0}// 373	374	375	
			, {3157, 15, -13, 0}, {3157, 19, -20, 0}, {3157, 20, -19, 0}// 376	377	378	
			, {3157, 19, -19, 0}, {3208, 21, -19, 0}, {3208, 20, -20, 0}// 379	380	381	
			, {3207, 21, -13, 0}, {3231, 15, -21, 0}, {3231, 21, -18, 0}// 382	383	384	
			, {6039, 14, -9, 0}, {6039, 14, -8, 0}, {6039, 14, -7, 0}// 385	386	387	
			, {6039, 14, -6, 0}, {6039, 14, -5, 0}, {6039, 14, -4, 0}// 388	389	390	
			, {6039, 14, -3, 0}, {6039, 14, -2, 0}, {6039, 14, -1, 0}// 391	392	393	
			, {6039, 14, 0, 0}, {6039, 14, 1, 0}, {6039, 14, 2, 0}// 394	395	396	
			, {6039, 14, 3, 0}, {6039, 14, 4, 0}, {6039, 14, 5, 0}// 397	398	399	
			, {6039, 14, 6, 0}, {6039, 15, -9, 0}, {6039, 15, -8, 0}// 400	401	402	
			, {6039, 15, -7, 0}, {6039, 15, -6, 0}, {6039, 15, -5, 0}// 403	404	405	
			, {6039, 15, -3, 0}, {6039, 15, -2, 0}, {6039, 15, -1, 0}// 406	407	408	
			, {6039, 15, 0, 0}, {6039, 15, 1, 0}, {6039, 15, 2, 0}// 409	410	411	
			, {6039, 15, 3, 0}, {6039, 15, 5, 0}, {6039, 15, 6, 0}// 412	413	414	
			, {6039, 16, -9, 0}, {6039, 16, -8, 0}, {6039, 16, -7, 0}// 415	416	417	
			, {6039, 16, -6, 0}, {6039, 16, -5, 0}, {6039, 16, -4, 0}// 418	419	420	
			, {6039, 16, -3, 0}, {6039, 16, -2, 0}, {6039, 16, -1, 0}// 421	422	423	
			, {6039, 16, 0, 0}, {6039, 16, 1, 0}, {6039, 16, 2, 0}// 424	425	426	
			, {6039, 16, 3, 0}, {6039, 16, 4, 0}, {6039, 16, 5, 0}// 427	428	429	
			, {6039, 16, 6, 0}, {6039, 17, -9, 0}, {6039, 17, -8, 0}// 430	431	432	
			, {6039, 17, -7, 0}, {6039, 17, -6, 0}, {6039, 17, -5, 0}// 433	434	435	
			, {6039, 17, -4, 0}, {6039, 17, -3, 0}, {6039, 17, -2, 0}// 436	437	438	
			, {6039, 17, -1, 0}, {6039, 17, 0, 0}, {6039, 17, 1, 0}// 439	440	441	
			, {6039, 17, 2, 0}, {6039, 17, 3, 0}, {6039, 17, 4, 0}// 442	443	444	
			, {6039, 17, 5, 0}, {6039, 17, 6, 0}, {6039, 18, -9, 0}// 445	446	447	
			, {6039, 18, -8, 0}, {6039, 18, -7, 0}, {6039, 18, -6, 0}// 448	449	450	
			, {6039, 18, -5, 0}, {6039, 18, -4, 0}, {6039, 18, -3, 0}// 451	452	453	
			, {6039, 18, -2, 0}, {6039, 18, -1, 0}, {6039, 18, 0, 0}// 454	455	456	
			, {6039, 18, 1, 0}, {6039, 18, 2, 0}, {6039, 18, 3, 0}// 457	458	459	
			, {6039, 18, 4, 0}, {6039, 18, 5, 0}, {6039, 18, 6, 0}// 460	461	462	
			, {6039, 19, -8, 0}, {6039, 19, -7, 0}, {6039, 19, -6, 0}// 463	464	465	
			, {6039, 19, -5, 0}, {6039, 19, -4, 0}, {6039, 19, -3, 0}// 466	467	468	
			, {6039, 19, -2, 0}, {6039, 19, 0, 0}, {6039, 19, 1, 0}// 469	470	471	
			, {6039, 19, 2, 0}, {6039, 19, 3, 0}, {6039, 19, 4, 0}// 472	473	474	
			, {6039, 19, 5, 0}, {6039, 20, -9, 0}, {6039, 20, -8, 0}// 475	476	477	
			, {6039, 20, -7, 0}, {6039, 20, -6, 0}, {6039, 20, -5, 0}// 478	479	480	
			, {6039, 20, -4, 0}, {6039, 20, -3, 0}, {6039, 20, -2, 0}// 481	482	483	
			, {6039, 20, -1, 0}, {6039, 20, 0, 0}, {6039, 20, 1, 0}// 484	485	486	
			, {6039, 20, 2, 0}, {6039, 20, 3, 0}, {6039, 20, 4, 0}// 487	488	489	
			, {6039, 20, 5, 0}, {6039, 20, 6, 0}, {6045, 21, -8, 0}// 490	491	492	
			, {6045, 21, -6, 0}, {6045, 21, -4, 0}, {6045, 21, -2, 0}// 493	494	495	
			, {6045, 21, 0, 0}, {6045, 21, 2, 0}, {6045, 21, 4, 0}// 496	497	498	
			, {6045, 21, 6, 0}, {6046, 21, -9, 0}, {6046, 21, -7, 0}// 499	500	501	
			, {6046, 21, -5, 0}, {6046, 21, -3, 0}, {6046, 21, -1, 0}// 502	503	504	
			, {6046, 21, 1, 0}, {6046, 21, 3, 0}, {6046, 21, 5, 0}// 505	506	507	
			, {13456, 19, -9, 0}, {13456, 15, -4, 0}, {13456, 19, -1, 0}// 508	509	510	
			, {13456, 15, 4, 0}, {13456, 19, 6, 0}, {3339, 16, 1, 1}// 511	512	513	
			, {3518, 19, -6, 1}, {3514, 19, 3, 0}, {3515, 15, -7, 0}// 514	515	516	
			, {3265, 21, 1, 0}, {3157, 14, -3, 0}, {3157, 14, -2, 0}// 517	518	519	
			, {3157, 15, -2, 0}, {3157, 21, -9, 0}, {3157, 20, -9, 0}// 520	521	522	
			, {3157, 21, -8, 0}, {3157, 21, 4, 0}, {3157, 20, 4, 0}// 523	524	525	
			, {3157, 21, 5, 0}, {3208, 21, -7, 0}, {3207, 21, -3, 0}// 526	527	528	
			, {3231, 21, -6, 0}, {6039, 10, 15, 0}, {6039, 11, 15, 0}// 529	530	531	
			, {6039, 12, 15, 0}, {6039, 13, 15, 0}, {6039, 10, 14, 0}// 532	533	534	
			, {6039, 11, 14, 0}, {6039, 12, 14, 0}, {6039, 13, 14, 0}// 535	536	537	
			, {6039, 10, 16, 0}, {6039, 10, 17, 0}, {6039, 10, 18, 0}// 538	539	540	
			, {6039, 10, 19, 0}, {6039, 10, 20, 0}, {6039, 11, 16, 0}// 541	542	543	
			, {6039, 11, 17, 0}, {6039, 11, 18, 0}, {6039, 11, 19, 0}// 544	545	546	
			, {6039, 11, 20, 0}, {6039, 12, 16, 0}, {6039, 12, 17, 0}// 547	548	549	
			, {6039, 12, 18, 0}, {6039, 12, 19, 0}, {6039, 12, 20, 0}// 550	551	552	
			, {6039, 13, 16, 0}, {6039, 13, 17, 0}, {6039, 13, 19, 0}// 553	554	555	
			, {6039, 13, 20, 0}, {6039, 14, 7, 0}, {6039, 14, 8, 0}// 556	557	558	
			, {6039, 14, 9, 0}, {6039, 14, 10, 0}, {6039, 14, 11, 0}// 559	560	561	
			, {6039, 14, 12, 0}, {6039, 14, 13, 0}, {6039, 16, 16, 0}// 562	563	564	
			, {6039, 14, 15, 0}, {6039, 14, 16, 0}, {6039, 14, 17, 0}// 565	566	567	
			, {6039, 14, 18, 0}, {6039, 14, 19, 0}, {6039, 14, 20, 0}// 568	569	570	
			, {6039, 15, 7, 0}, {6039, 15, 8, 0}, {6039, 15, 9, 0}// 571	572	573	
			, {6039, 15, 11, 0}, {6039, 15, 12, 0}, {6039, 15, 13, 0}// 574	575	576	
			, {6039, 15, 14, 0}, {6039, 15, 15, 0}, {6039, 15, 16, 0}// 577	578	579	
			, {6039, 15, 17, 0}, {6039, 15, 18, 0}, {6039, 15, 19, 0}// 580	581	582	
			, {6039, 16, 7, 0}, {6039, 16, 8, 0}, {6039, 16, 9, 0}// 583	584	585	
			, {6039, 16, 10, 0}, {6039, 16, 11, 0}, {6039, 16, 12, 0}// 586	587	588	
			, {6039, 16, 13, 0}, {6039, 16, 14, 0}, {6039, 16, 15, 0}// 589	590	591	
			, {6039, 16, 17, 0}, {6039, 16, 18, 0}, {6039, 16, 19, 0}// 592	593	594	
			, {6039, 17, 7, 0}, {6039, 17, 8, 0}, {6039, 17, 9, 0}// 595	596	597	
			, {6039, 17, 10, 0}, {6039, 17, 11, 0}, {6039, 17, 12, 0}// 598	599	600	
			, {6039, 17, 13, 0}, {6039, 17, 14, 0}, {6039, 17, 15, 0}// 601	602	603	
			, {6039, 17, 16, 0}, {6039, 17, 17, 0}, {6039, 17, 18, 0}// 604	605	606	
			, {6039, 18, 7, 0}, {6039, 18, 8, 0}, {6039, 18, 9, 0}// 607	608	609	
			, {6039, 18, 10, 0}, {6039, 18, 11, 0}, {6039, 18, 12, 0}// 610	611	612	
			, {6039, 18, 13, 0}, {6039, 18, 14, 0}, {6039, 18, 15, 0}// 613	614	615	
			, {6039, 18, 16, 0}, {6039, 18, 17, 0}, {6039, 19, 7, 0}// 616	617	618	
			, {6039, 19, 8, 0}, {6039, 19, 9, 0}, {6039, 19, 10, 0}// 619	620	621	
			, {6039, 19, 11, 0}, {6039, 19, 12, 0}, {6039, 19, 14, 0}// 622	623	624	
			, {6039, 19, 15, 0}, {6039, 19, 16, 0}, {6039, 20, 7, 0}// 625	626	627	
			, {6039, 20, 8, 0}, {6039, 20, 9, 0}, {6039, 20, 10, 0}// 628	629	630	
			, {6039, 20, 11, 0}, {6039, 20, 12, 0}, {6039, 20, 13, 0}// 631	632	633	
			, {6039, 20, 14, 0}, {6049, 10, 21, 0}, {6049, 12, 21, 0}// 634	635	636	
			, {6049, 14, 21, 0}, {6045, 21, 8, 0}, {6045, 21, 10, 0}// 637	638	639	
			, {6045, 21, 12, 0}, {6045, 21, 14, 0}, {6046, 21, 7, 0}// 640	641	642	
			, {6046, 21, 9, 0}, {6046, 21, 11, 0}, {6046, 21, 13, 0}// 643	644	645	
			, {6050, 11, 21, 0}, {6050, 13, 21, 0}, {6058, 15, 20, 0}// 646	647	648	
			, {6058, 18, 18, 0}, {6058, 20, 15, 0}, {6058, 17, 19, 0}// 649	650	651	
			, {6058, 19, 17, 0}, {6065, 15, 21, 0}, {6065, 18, 19, 0}// 652	653	654	
			, {6065, 19, 18, 0}, {6065, 21, 15, 0}, {6050, 16, 20, 0}// 655	656	657	
			, {6046, 20, 16, 0}, {6055, 17, 20, 0}, {6055, 20, 17, 0}// 658	659	660	
			, {13456, 15, 10, 0}, {13456, 19, 13, 0}, {13456, 14, 14, 0}// 661	662	663	
			, {13456, 13, 18, 0}, {3339, 11, 16, 1}, {3518, 19, 11, 1}// 664	665	666	
			, {3514, 17, 17, 0}, {3514, 15, 7, 0}, {3157, 10, 14, 0}// 667	668	669	
			, {3157, 10, 15, 0}, {3332, 13, 14, 0}, {3332, 16, 19, 0}// 670	671	672	
			, {3208, 20, 15, 0}, {3208, 15, 20, 0}, {3237, 21, 9, 0}// 673	674	675	
			, {3157, 14, 12, 0}, {3157, 14, 11, 0}, {3157, 15, 12, 0}// 676	677	678	
			, {3207, 21, 12, 0}, {3224, 19, 19, 0}, {3231, 20, 16, 0}// 679	680	681	
			, {3231, 15, 21, 0}// 682	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FourPlotSouthEastMoatAddonDeed();
			}
		}

		[ Constructable ]
		public FourPlotSouthEastMoatAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public FourPlotSouthEastMoatAddon( Serial serial ) : base( serial )
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

	public class FourPlotSouthEastMoatAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FourPlotSouthEastMoatAddon();
			}
		}

		[Constructable]
		public FourPlotSouthEastMoatAddonDeed()
		{
			Name = "FourPlotSouthEastMoat";
		}

		public FourPlotSouthEastMoatAddonDeed( Serial serial ) : base( serial )
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