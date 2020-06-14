
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
	public class CraftingBldgAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1900, -8, -5, 0}, {1900, -8, -4, 0}, {1900, -8, -3, 0}// 1	2	3	
			, {1900, -8, -2, 0}, {1900, -8, -1, 0}, {1900, -8, 0, 0}// 4	5	6	
			, {1900, -8, 1, 0}, {1900, -8, 2, 0}, {1900, -8, 3, 0}// 7	8	9	
			, {1900, -8, 4, 0}, {1900, -7, -5, 0}, {1900, -7, -4, 0}// 10	11	12	
			, {1900, -7, -3, 0}, {1900, -7, -2, 0}, {1900, -7, -1, 0}// 13	14	15	
			, {1900, -7, 0, 0}, {1900, -7, 1, 0}, {1900, -7, 2, 0}// 16	17	18	
			, {1900, -7, 3, 0}, {1900, -7, 4, 0}, {1900, -6, -5, 0}// 19	20	21	
			, {1900, -6, -4, 0}, {1900, -6, -3, 0}, {1900, -6, -2, 0}// 22	23	24	
			, {1900, -6, -1, 0}, {1900, -6, 0, 0}, {1900, -6, 1, 0}// 25	26	27	
			, {1900, -6, 2, 0}, {1900, -6, 3, 0}, {1900, -6, 4, 0}// 28	29	30	
			, {1900, -5, -5, 0}, {1900, -5, -4, 0}, {1900, -5, -3, 0}// 31	32	33	
			, {1900, -5, -2, 0}, {1900, -5, -1, 0}, {1900, -5, 0, 0}// 34	35	36	
			, {1900, -5, 1, 0}, {1900, -5, 2, 0}, {1900, -5, 3, 0}// 37	38	39	
			, {1900, -5, 4, 0}, {1900, -4, -5, 0}, {1900, -4, -4, 0}// 40	41	42	
			, {1900, -4, -3, 0}, {1900, -4, -2, 0}, {1900, -4, -1, 0}// 43	44	45	
			, {1900, -4, 0, 0}, {1900, -4, 1, 0}, {1900, -4, 2, 0}// 46	47	48	
			, {1900, -4, 3, 0}, {1900, -4, 4, 0}, {1900, -3, -5, 0}// 49	50	51	
			, {1900, -3, -4, 0}, {1900, -3, -3, 0}, {1900, -3, -2, 0}// 52	53	54	
			, {1900, -3, -1, 0}, {1900, -3, 0, 0}, {1900, -3, 1, 0}// 55	56	57	
			, {1900, -3, 2, 0}, {1900, -3, 3, 0}, {1900, -3, 4, 0}// 58	59	60	
			, {1900, -2, -5, 0}, {1900, -2, -4, 0}, {1900, -2, -3, 0}// 61	62	63	
			, {1900, -2, -2, 0}, {1900, -2, -1, 0}, {1900, -2, 0, 0}// 64	65	66	
			, {1900, -2, 1, 0}, {1900, -2, 2, 0}, {1900, -2, 3, 0}// 67	68	69	
			, {1900, -2, 4, 0}, {1900, -1, -5, 0}, {1900, -1, -4, 0}// 70	71	72	
			, {1900, -1, -3, 0}, {1900, -1, -2, 0}, {1900, -1, -1, 0}// 73	74	75	
			, {1900, -1, 0, 0}, {1900, -1, 1, 0}, {1900, -1, 2, 0}// 76	77	78	
			, {1900, -1, 3, 0}, {1900, -1, 4, 0}, {1900, 0, -5, 0}// 79	80	81	
			, {1900, 0, -4, 0}, {1900, 0, -3, 0}, {1900, 0, -2, 0}// 82	83	84	
			, {1900, 0, -1, 0}, {1900, 0, 0, 0}, {1900, 0, 1, 0}// 85	86	87	
			, {1900, 0, 2, 0}, {1900, 0, 3, 0}, {1900, 0, 4, 0}// 88	89	90	
			, {1900, 1, -5, 0}, {1900, 1, -4, 0}, {1900, 1, -3, 0}// 91	92	93	
			, {1900, 1, -2, 0}, {1900, 1, -1, 0}, {1900, 1, 0, 0}// 94	95	96	
			, {1900, 1, 1, 0}, {1900, 1, 2, 0}, {1900, 1, 3, 0}// 97	98	99	
			, {1900, 1, 4, 0}, {1900, 2, -5, 0}, {1900, 2, -4, 0}// 100	101	102	
			, {1900, 2, -3, 0}, {1900, 2, -2, 0}, {1900, 2, -1, 0}// 103	104	105	
			, {1900, 2, 0, 0}, {1900, 2, 1, 0}, {1900, 2, 2, 0}// 106	107	108	
			, {1900, 2, 3, 0}, {1900, 2, 4, 0}, {1900, 3, -5, 0}// 109	110	111	
			, {1900, 3, -4, 0}, {1900, 3, -3, 0}, {1900, 3, -2, 0}// 112	113	114	
			, {1900, 3, -1, 0}, {1900, 3, 0, 0}, {1900, 3, 1, 0}// 115	116	117	
			, {1900, 3, 2, 0}, {1900, 3, 3, 0}, {1900, 3, 4, 0}// 118	119	120	
			, {1900, 4, -5, 0}, {1900, 4, -4, 0}, {1900, 4, -3, 0}// 121	122	123	
			, {1900, 4, -2, 0}, {1900, 4, -1, 0}, {1900, 4, 0, 0}// 124	125	126	
			, {1900, 4, 1, 0}, {1900, 4, 2, 0}, {1900, 4, 3, 0}// 127	128	129	
			, {1900, 4, 4, 0}, {1900, 5, -5, 0}, {1900, 5, -4, 0}// 130	131	132	
			, {1900, 5, -3, 0}, {1900, 5, -2, 0}, {1900, 5, -1, 0}// 133	134	135	
			, {1900, 5, 0, 0}, {1900, 5, 1, 0}, {1900, 5, 2, 0}// 136	137	138	
			, {1900, 5, 3, 0}, {1900, 5, 4, 0}, {1901, -8, 5, 0}// 139	140	141	
			, {1901, -7, 5, 0}, {1901, -6, 5, 0}, {1901, -5, 5, 0}// 142	143	144	
			, {1901, -4, 5, 0}, {1901, -3, 5, 0}, {1901, -2, 5, 0}// 145	146	147	
			, {1901, -1, 5, 0}, {1901, 0, 5, 0}, {1901, 1, 5, 0}// 148	149	150	
			, {1901, 2, 5, 0}, {1901, 3, 5, 0}, {1901, 4, 5, 0}// 151	152	153	
			, {1901, 5, 5, 0}, {1903, -8, -6, 0}, {1903, -7, -6, 0}// 154	155	156	
			, {1903, -6, -6, 0}, {1903, -5, -6, 0}, {1903, -4, -6, 0}// 157	158	159	
			, {1903, -3, -6, 0}, {1903, -2, -6, 0}, {1903, -1, -6, 0}// 160	161	162	
			, {1903, 0, -6, 0}, {1903, 1, -6, 0}, {1903, 2, -6, 0}// 163	164	165	
			, {1903, 3, -6, 0}, {1903, 4, -6, 0}, {1903, 5, -6, 0}// 166	167	168	
			, {1904, -9, -5, 0}, {1904, -9, -4, 0}, {1904, -9, -3, 0}// 169	170	171	
			, {1904, -9, -2, 0}, {1904, -9, -1, 0}, {1904, -9, 0, 0}// 172	173	174	
			, {1904, -9, 1, 0}, {1904, -9, 2, 0}, {1904, -9, 3, 0}// 175	176	177	
			, {1904, -9, 4, 0}, {1905, -9, -6, 0}, {1908, -9, 5, 0}// 178	179	180	
			, {393, -7, 6, 31}, {393, -7, -4, 31}, {393, 1, 6, 31}// 181	182	183	
			, {393, 1, -4, 31}, {1790, -6, 7, 57}, {1791, -6, -3, 57}// 184	189	190	
			, {1792, 5, 1, 69}, {1791, -5, -2, 60}, {1791, -4, -1, 63}// 191	192	193	
			, {1791, -3, 0, 66}, {1791, -2, 1, 69}, {1790, -5, 6, 60}// 194	195	196	
			, {1790, -4, 5, 63}, {1790, -3, 4, 66}, {1790, -2, 3, 69}// 197	198	199	
			, {1789, 5, 3, 69}, {8681, 5, 2, 69}, {8683, -6, -2, 57}// 200	201	202	
			, {8683, -6, -1, 57}, {8683, -6, 0, 57}, {8683, -6, 1, 57}// 203	204	205	
			, {8683, -6, 2, 57}, {8683, -6, 3, 57}, {8683, -6, 4, 57}// 206	207	208	
			, {8683, -6, 5, 57}, {8683, -6, 6, 57}, {8683, -5, -1, 60}// 209	210	211	
			, {8683, -5, 0, 60}, {8683, -5, 1, 60}, {8683, -5, 2, 60}// 212	213	214	
			, {8683, -5, 3, 60}, {8683, -5, 4, 60}, {8683, -5, 5, 60}// 215	216	217	
			, {8683, -4, 0, 63}, {8683, -4, 1, 63}, {8683, -4, 2, 63}// 218	219	220	
			, {8683, -4, 3, 63}, {8683, -4, 4, 63}, {8683, -3, 1, 66}// 221	222	223	
			, {8683, -3, 2, 66}, {8683, -3, 3, 66}, {8683, -2, 2, 69}// 224	225	226	
			, {8685, -5, 7, 57}, {8685, -4, 7, 57}, {8685, -3, 7, 57}// 227	228	229	
			, {8685, -2, 7, 57}, {8685, -1, 7, 57}, {8685, 0, 7, 57}// 230	231	232	
			, {8685, 1, 7, 57}, {8685, 2, 7, 57}, {8685, 3, 7, 57}// 233	234	235	
			, {8685, 4, 7, 57}, {8685, 5, 7, 57}, {8685, -4, 6, 60}// 236	237	238	
			, {8685, -3, 6, 60}, {8685, -2, 6, 60}, {8685, -1, 6, 60}// 239	240	241	
			, {8685, 0, 6, 60}, {8685, 1, 6, 60}, {8685, 2, 6, 60}// 242	243	244	
			, {8685, 3, 6, 60}, {8685, 4, 6, 60}, {8685, 5, 6, 60}// 245	246	247	
			, {8685, -3, 5, 63}, {8685, -2, 5, 63}, {8685, -1, 5, 63}// 248	249	250	
			, {8685, 0, 5, 63}, {8685, 1, 5, 63}, {8685, 2, 5, 63}// 251	252	253	
			, {8685, 3, 5, 63}, {8685, 4, 5, 63}, {8685, 5, 5, 63}// 254	255	256	
			, {8685, -2, 4, 66}, {8685, -1, 4, 66}, {8685, 0, 4, 66}// 257	258	259	
			, {8685, 1, 4, 66}, {8685, 2, 4, 66}, {8685, 3, 4, 66}// 260	261	262	
			, {8685, 4, 4, 66}, {8685, 5, 4, 66}, {8685, -1, 3, 69}// 263	264	265	
			, {8685, 0, 3, 69}, {8685, 1, 3, 69}, {8685, 2, 3, 69}// 266	267	268	
			, {8685, 3, 3, 69}, {8685, 4, 3, 69}, {8687, -5, -3, 57}// 269	270	271	
			, {8687, -4, -3, 57}, {8687, -3, -3, 57}, {8687, -2, -3, 57}// 272	273	274	
			, {8687, -1, -3, 57}, {8687, 0, -3, 57}, {8687, 1, -3, 57}// 275	276	277	
			, {8687, 2, -3, 57}, {8687, 3, -3, 57}, {8687, 4, -3, 57}// 278	279	280	
			, {8687, 5, -3, 57}, {8687, -4, -2, 60}, {8687, -3, -2, 60}// 281	282	283	
			, {8687, -2, -2, 60}, {8687, -1, -2, 60}, {8687, 0, -2, 60}// 284	285	286	
			, {8687, 1, -2, 60}, {8687, 2, -2, 60}, {8687, 3, -2, 60}// 287	288	289	
			, {8687, 4, -2, 60}, {8687, 5, -2, 60}, {8687, -3, -1, 63}// 290	291	292	
			, {8687, -2, -1, 63}, {8687, -1, -1, 63}, {8687, 0, -1, 63}// 293	294	295	
			, {8687, 1, -1, 63}, {8687, 2, -1, 63}, {8687, 3, -1, 63}// 296	297	298	
			, {8687, 4, -1, 63}, {8687, 5, -1, 63}, {8687, -2, 0, 66}// 299	300	301	
			, {8687, -1, 0, 66}, {8687, 0, 0, 66}, {8687, 1, 0, 66}// 302	303	304	
			, {8687, 2, 0, 66}, {8687, 3, 0, 66}, {8687, 4, 0, 66}// 305	306	307	
			, {8687, 5, 0, 66}, {8687, -1, 1, 69}, {8687, 0, 1, 69}// 308	309	310	
			, {8687, 1, 1, 69}, {8687, 2, 1, 69}, {8687, 3, 1, 69}// 311	312	313	
			, {8687, 4, 1, 69}, {1471, -1, 2, 72}, {1471, 0, 2, 72}// 314	315	316	
			, {1471, 1, 2, 72}, {1471, 2, 2, 72}, {1471, 3, 2, 72}// 317	318	319	
			, {1471, 4, 2, 72}, {6534, -7, -2, 5}, {6550, -7, 0, 5}// 320	321	323	
			, {6546, -7, 1, 5}, {4016, -6, 1, 5}, {4016, -6, -2, 5}// 324	325	326	
			, {2883, -5, -4, 5}, {2884, -4, -4, 5}, {6790, -6, 2, 5}// 327	328	329	
			, {6787, -6, 3, 5}, {6786, -6, 4, 5}, {6584, -7, 4, 5}// 330	331	332	
			, {3897, -3, 3, 5}, {4022, -7, 2, 5}, {7147, -3, 0, 5}// 333	334	335	
			, {7141, -3, -1, 5}, {7153, -3, 1, 5}, {7159, -3, -2, 5}// 336	337	338	
			, {7611, -1, 2, 5}, {7612, -1, -3, 5}, {7613, -1, -2, 5}// 339	340	341	
			, {7613, -1, -1, 5}, {7613, -1, 0, 5}, {7613, -1, 1, 5}// 342	343	344	
			, {7138, -2, 4, 5}, {6647, 2, 3, 5}, {6646, 3, 3, 5}// 345	346	347	
			, {6645, 4, 3, 5}, {6648, 4, 4, 5}, {4152, 2, 4, 5}// 348	349	350	
			, {4152, 5, 2, 5}, {6649, 0, 2, 5}, {6650, 0, 1, 5}// 351	352	353	
			, {7791, 5, 4, 5}, {4134, 3, 3, 8}, {4143, 3, 3, 14}// 354	355	356	
			, {7797, 3, 4, 5}, {7861, 0, 3, 5}, {7858, 1, 1, 5}// 357	358	359	
			, {7607, 0, 1, 7}, {7608, 0, 0, 5}, {4021, -1, 2, 11}// 360	361	362	
			, {4027, -1, 1, 11}, {7864, -1, -3, 11}, {7867, -1, 0, 11}// 363	364	365	
			, {6262, -1, -2, 11}, {3577, 5, -5, 5}, {3576, 4, -5, 5}// 366	367	368	
			, {3999, 4, -4, 5}, {4009, 5, -1, 5}, {3782, 0, -5, 5}// 369	373	374	
			, {1900, 6, -5, 0}, {1900, 6, -4, 0}, {1900, 6, -3, 0}// 375	376	377	
			, {1900, 6, -2, 0}, {1900, 6, -1, 0}, {1900, 6, 0, 0}// 378	379	380	
			, {1900, 6, 1, 0}, {1900, 6, 2, 0}, {1900, 6, 3, 0}// 381	382	383	
			, {1900, 6, 4, 0}, {1901, 6, 5, 0}, {1902, 7, -5, 0}// 384	385	386	
			, {1902, 7, -4, 0}, {1902, 7, -3, 0}, {1902, 7, -2, 0}// 387	388	389	
			, {1902, 7, -1, 0}, {1902, 7, 0, 0}, {1902, 7, 1, 0}// 390	391	392	
			, {1902, 7, 2, 0}, {1902, 7, 3, 0}, {1902, 7, 4, 0}// 393	394	395	
			, {1903, 6, -6, 0}, {1906, 7, 5, 0}, {1907, 7, -6, 0}// 396	397	398	
			, {393, 8, -4, 31}, {393, 8, 6, 31}, {1789, 9, 7, 57}// 399	400	403	
			, {1789, 8, 6, 60}, {1789, 7, 5, 63}, {1792, 9, -3, 57}// 404	405	406	
			, {8681, 9, -2, 57}, {8681, 9, -1, 57}, {8681, 9, 0, 57}// 407	408	409	
			, {8681, 9, 1, 57}, {8681, 9, 2, 57}, {8681, 9, 3, 57}// 410	411	412	
			, {8681, 9, 4, 57}, {8681, 9, 5, 57}, {8681, 9, 6, 57}// 413	414	415	
			, {1792, 8, -2, 60}, {1792, 7, -1, 63}, {1792, 6, 0, 66}// 416	417	418	
			, {1789, 6, 4, 66}, {8681, 8, -1, 60}, {8681, 8, 0, 60}// 419	420	421	
			, {8681, 8, 1, 60}, {8681, 8, 2, 60}, {8681, 8, 3, 60}// 422	423	424	
			, {8681, 8, 4, 60}, {8681, 8, 5, 60}, {8681, 7, 0, 63}// 425	426	427	
			, {8681, 7, 1, 63}, {8681, 7, 2, 63}, {8681, 7, 3, 63}// 428	429	430	
			, {8681, 7, 4, 63}, {8681, 6, 1, 66}, {8681, 6, 3, 66}// 431	432	433	
			, {8681, 6, 2, 66}, {8685, 6, 7, 57}, {8685, 7, 7, 57}// 434	435	436	
			, {8685, 8, 7, 57}, {8685, 6, 6, 60}, {8685, 7, 6, 60}// 437	438	439	
			, {8685, 6, 5, 63}, {8687, 6, -3, 57}, {8687, 7, -3, 57}// 440	441	442	
			, {8687, 8, -3, 57}, {8687, 6, -2, 60}, {8687, 7, -2, 60}// 443	444	445	
			, {8687, 6, -1, 63}, {7793, 6, 3, 5}, {4220, 6, -5, 5}// 446	447	448	
			, {4598, 6, -4, 5}, {4596, 6, -3, 5}, {4011, 6, -1, 5}// 449	450	451	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CraftingBldgAddonDeed();
			}
		}

		[ Constructable ]
		public CraftingBldgAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 424, -9, -6, 5, 50, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 424, -9, 4, 5, 50, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 424, -1, -6, 5, 50, -1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 424, -1, 4, 5, 50, -1, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 6538, -7, -1, 5, 0, 29, "", 1);// 322
			AddComplexComponent( (BaseAddon) this, 5981, 4, -3, 5, 93, -1, "", 1);// 370
			AddComplexComponent( (BaseAddon) this, 5981, 4, -3, 6, 33, -1, "", 1);// 371
			AddComplexComponent( (BaseAddon) this, 5981, 4, -3, 7, 1369, -1, "", 1);// 372
			AddComplexComponent( (BaseAddon) this, 424, 6, -6, 5, 50, -1, "", 1);// 401
			AddComplexComponent( (BaseAddon) this, 424, 6, 4, 5, 50, -1, "", 1);// 402

		}

		public CraftingBldgAddon( Serial serial ) : base( serial )
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

	public class CraftingBldgAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CraftingBldgAddon();
			}
		}

		[Constructable]
		public CraftingBldgAddonDeed()
		{
			Name = "CraftingBldg";
		}

		public CraftingBldgAddonDeed( Serial serial ) : base( serial )
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