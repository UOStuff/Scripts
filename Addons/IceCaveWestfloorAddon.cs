
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
	public class IceCaveWestfloorAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {578, -8, 1, 0}, {578, -8, 2, 0}, {578, -8, 3, 0}// 1	 2	 3	 
			, {578, -8, 4, 0}, {578, -8, 5, 0}, {578, -8, 6, 0}// 4	 5	 6	 
			, {578, -8, 7, 0}, {578, -8, 8, 0}, {580, -8, -8, 0}// 7	 8	 9	 
			, {578, -8, -7, 0}, {578, -8, -6, 0}, {578, -8, -5, 0}// 10	 11	 12	 
			, {578, -8, -4, 0}, {578, -8, -3, 0}, {578, -8, -2, 0}// 13	 14	 15	 
			, {578, -8, -1, 0}, {578, -8, 0, 0}, {6090, -8, 9, 0}// 16	 17	 18	
			, {6077, -7, -8, 0}, {6077, -7, -7, 0}, {6077, -7, -6, 0}// 19	20	21	
			, {6077, -7, -5, 0}, {6077, -7, -4, 0}, {6077, -7, -3, 0}// 22	23	24	
			, {6077, -7, -2, 0}, {6077, -7, -1, 0}, {6077, -7, 0, 0}// 25	26	27	
			, {6077, -6, -8, 0}, {6077, -6, -7, 0}, {6077, -6, -6, 0}// 28	29	30	
			, {6077, -6, -5, 0}, {6077, -6, -4, 0}, {6077, -6, -3, 0}// 31	32	33	
			, {6077, -6, -2, 0}, {6077, -6, -1, 0}, {6077, -6, 0, 0}// 34	35	36	
			, {6077, -5, -8, 0}, {6077, -5, -7, 0}, {6077, -5, -6, 0}// 37	38	39	
			, {6077, -5, -5, 0}, {6077, -5, -4, 0}, {6077, -5, -3, 0}// 40	41	42	
			, {6077, -5, -2, 0}, {6077, -5, -1, 0}, {6077, -5, 0, 0}// 43	44	45	
			, {6077, -4, -8, 0}, {6077, -4, -7, 0}, {6077, -4, -6, 0}// 46	47	48	
			, {6077, -4, -5, 0}, {6077, -4, -4, 0}, {6077, -4, -3, 0}// 49	50	51	
			, {6077, -4, -2, 0}, {6077, -4, -1, 0}, {6077, -4, 0, 0}// 52	53	54	
			, {6077, -3, -8, 0}, {6077, -3, -7, 0}, {6077, -3, -6, 0}// 55	56	57	
			, {6077, -3, -5, 0}, {6077, -3, -4, 0}, {6077, -3, -3, 0}// 58	59	60	
			, {6077, -3, -2, 0}, {6077, -3, -1, 0}, {6077, -3, 0, 0}// 61	62	63	
			, {6077, -2, -8, 0}, {6077, -2, -7, 0}, {6077, -2, -6, 0}// 64	65	66	
			, {6077, -2, -5, 0}, {6077, -2, -4, 0}, {6077, -2, -3, 0}// 67	68	69	
			, {6077, -2, -2, 0}, {6077, -2, -1, 0}, {6077, -2, 0, 0}// 70	71	72	
			, {6077, -1, -8, 0}, {6077, -1, -7, 0}, {6077, -1, -6, 0}// 73	74	75	
			, {6077, -1, -5, 0}, {6077, -1, -4, 0}, {6077, -1, -3, 0}// 76	77	78	
			, {6077, -1, -2, 0}, {6077, -1, -1, 0}, {6077, -1, 0, 0}// 79	80	81	
			, {6077, 0, -8, 0}, {6077, 0, -7, 0}, {6077, 0, -6, 0}// 82	83	84	
			, {6077, 0, -5, 0}, {6077, 0, -4, 0}, {6077, 0, -3, 0}// 85	86	87	
			, {6077, 0, -2, 0}, {6077, 0, -1, 0}, {6077, 0, 0, 0}// 88	89	90	
			, {6077, 1, -8, 0}, {6077, 1, -7, 0}, {6077, 1, -6, 0}// 91	92	93	
			, {6077, 1, -5, 0}, {6077, 1, -4, 0}, {6077, 1, -3, 0}// 94	95	96	
			, {6077, 1, -2, 0}, {6077, 1, -1, 0}, {6077, 1, 0, 0}// 97	98	99	
			, {6077, 2, -8, 0}, {6077, 2, -7, 0}, {6077, 2, -6, 0}// 100	101	102	
			, {6077, 2, -5, 0}, {6077, 2, -4, 0}, {6077, 2, -3, 0}// 103	104	105	
			, {6077, 2, -2, 0}, {6077, 2, -1, 0}, {6077, 2, 0, 0}// 106	107	108	
			, {6077, 3, -8, 0}, {6077, 3, -7, 0}, {6077, 3, -6, 0}// 109	110	111	
			, {6077, 3, -5, 0}, {6077, 3, -4, 0}, {6077, 3, -3, 0}// 112	113	114	
			, {6077, 3, -2, 0}, {6077, 3, -1, 0}, {6077, 3, 0, 0}// 115	116	117	
			, {6077, 4, -8, 0}, {6077, 4, -7, 0}, {6077, 4, -6, 0}// 118	119	120	
			, {6077, 4, -5, 0}, {6077, 4, -4, 0}, {6077, 4, -3, 0}// 121	122	123	
			, {6077, 4, -2, 0}, {6077, 4, -1, 0}, {6077, 4, 0, 0}// 124	125	126	
			, {6077, 5, -8, 0}, {6077, 5, -7, 0}, {6077, 5, -6, 0}// 127	128	129	
			, {6077, 5, -5, 0}, {6077, 5, -4, 0}, {6077, 5, -3, 0}// 130	131	132	
			, {6077, 5, -2, 0}, {6077, 5, -1, 0}, {6077, 5, 0, 0}// 133	134	135	
			, {6077, 6, -8, 0}, {6077, 6, -7, 0}, {6077, 6, -6, 0}// 136	137	138	
			, {6077, 6, -5, 0}, {6077, 6, -4, 0}, {6077, 6, -3, 0}// 139	140	141	
			, {6077, 6, -2, 0}, {6077, 6, -1, 0}, {6077, 6, 0, 0}// 142	143	144	
			, {6077, 7, -8, 0}, {6077, 7, -7, 0}, {6077, 7, -6, 0}// 145	146	147	
			, {6077, 7, -5, 0}, {6077, 7, -4, 0}, {6077, 7, -3, 0}// 148	149	150	
			, {6077, 7, -2, 0}, {6077, 7, -1, 0}, {6077, 7, 0, 0}// 151	152	153	
			, {6077, 8, -8, 0}, {6077, 8, -7, 0}, {6077, 8, -6, 0}// 154	155	156	
			, {6077, 8, -5, 0}, {6077, 8, -4, 0}, {6077, 8, -3, 0}// 157	158	159	
			, {6077, 8, -2, 0}, {6077, 8, -1, 0}, {6077, 8, 0, 0}// 160	161	162	
			, {6077, -7, 1, 0}, {6077, -7, 2, 0}, {6077, -7, 3, 0}// 197	198	199	
			, {6077, -7, 4, 0}, {6077, -7, 5, 0}, {6077, -7, 6, 0}// 200	201	202	
			, {6077, -7, 7, 0}, {6077, -7, 8, 0}, {6077, -7, 9, 0}// 203	204	205	
			, {6077, -6, 1, 0}, {6077, -6, 2, 0}, {6077, -6, 3, 0}// 206	207	208	
			, {6077, -6, 4, 0}, {6077, -6, 5, 0}, {6077, -6, 6, 0}// 209	210	211	
			, {6077, -6, 7, 0}, {6077, -6, 8, 0}, {6077, -6, 9, 0}// 212	213	214	
			, {6077, -5, 1, 0}, {6077, -5, 2, 0}, {6077, -5, 3, 0}// 215	216	217	
			, {6077, -5, 4, 0}, {6077, -5, 5, 0}, {6077, -5, 6, 0}// 218	219	220	
			, {6077, -5, 7, 0}, {6077, -5, 8, 0}, {6077, -5, 9, 0}// 221	222	223	
			, {6077, -4, 1, 0}, {6077, -4, 2, 0}, {6077, -4, 3, 0}// 224	225	226	
			, {6077, -4, 4, 0}, {6077, -4, 5, 0}, {6077, -4, 6, 0}// 227	228	229	
			, {6077, -4, 7, 0}, {6077, -4, 8, 0}, {6077, -4, 9, 0}// 230	231	232	
			, {6077, -3, 1, 0}, {6077, -3, 2, 0}, {6077, -3, 3, 0}// 233	234	235	
			, {6077, -3, 4, 0}, {6077, -3, 5, 0}, {6077, -3, 6, 0}// 236	237	238	
			, {6077, -3, 7, 0}, {6077, -3, 8, 0}, {6077, -3, 9, 0}// 239	240	241	
			, {6077, -2, 1, 0}, {6077, -2, 2, 0}, {6077, -2, 3, 0}// 242	243	244	
			, {6077, -2, 4, 0}, {6077, -2, 5, 0}, {6077, -2, 6, 0}// 245	246	247	
			, {6077, -2, 7, 0}, {6077, -2, 8, 0}, {6077, -2, 9, 0}// 248	249	250	
			, {6077, -1, 1, 0}, {6077, -1, 2, 0}, {6077, -1, 3, 0}// 251	252	253	
			, {6077, -1, 4, 0}, {6077, -1, 5, 0}, {6077, -1, 6, 0}// 254	255	256	
			, {6077, -1, 7, 0}, {6077, -1, 8, 0}, {6077, -1, 9, 0}// 257	258	259	
			, {6077, 0, 1, 0}, {6077, 0, 2, 0}, {6077, 0, 3, 0}// 260	261	262	
			, {6077, 0, 4, 0}, {6077, 0, 5, 0}, {6077, 0, 6, 0}// 263	264	265	
			, {6077, 0, 7, 0}, {6077, 0, 8, 0}, {6077, 0, 9, 0}// 266	267	268	
			, {6077, 1, 1, 0}, {6077, 1, 2, 0}, {6077, 1, 3, 0}// 269	270	271	
			, {6077, 1, 4, 0}, {6077, 1, 5, 0}, {6077, 1, 6, 0}// 272	273	274	
			, {6077, 1, 7, 0}, {6077, 1, 8, 0}, {6077, 1, 9, 0}// 275	276	277	
			, {6077, 2, 1, 0}, {6077, 2, 2, 0}, {6077, 2, 3, 0}// 278	279	280	
			, {6077, 2, 4, 0}, {6077, 2, 5, 0}, {6077, 2, 6, 0}// 281	282	283	
			, {6077, 2, 7, 0}, {6077, 2, 8, 0}, {6077, 2, 9, 0}// 284	285	286	
			, {6077, 3, 1, 0}, {6077, 3, 2, 0}, {6077, 3, 3, 0}// 287	288	289	
			, {6077, 3, 4, 0}, {6077, 3, 5, 0}, {6077, 3, 6, 0}// 290	291	292	
			, {6077, 3, 7, 0}, {6077, 3, 8, 0}, {6077, 3, 9, 0}// 293	294	295	
			, {6077, 4, 1, 0}, {6077, 4, 2, 0}, {6077, 4, 3, 0}// 296	297	298	
			, {6077, 4, 4, 0}, {6077, 4, 5, 0}, {6077, 4, 6, 0}// 299	300	301	
			, {6077, 4, 7, 0}, {6077, 4, 8, 0}, {6077, 4, 9, 0}// 302	303	304	
			, {6077, 5, 1, 0}, {6077, 5, 2, 0}, {6077, 5, 3, 0}// 305	306	307	
			, {6077, 5, 4, 0}, {6077, 5, 5, 0}, {6077, 5, 6, 0}// 308	309	310	
			, {6077, 5, 7, 0}, {6077, 5, 8, 0}, {6077, 5, 9, 0}// 311	312	313	
			, {6077, 6, 1, 0}, {6077, 6, 2, 0}, {6077, 6, 3, 0}// 314	315	316	
			, {6077, 6, 4, 0}, {6077, 6, 5, 0}, {6077, 6, 6, 0}// 317	318	319	
			, {6077, 6, 7, 0}, {6077, 6, 8, 0}, {6077, 6, 9, 0}// 320	321	322	
			, {6077, 7, 1, 0}, {6077, 7, 2, 0}, {6077, 7, 3, 0}// 323	324	325	
			, {6077, 7, 4, 0}, {6077, 7, 5, 0}, {6077, 7, 6, 0}// 326	327	328	
			, {6077, 7, 7, 0}, {6077, 7, 8, 0}, {6077, 7, 9, 0}// 329	330	331	
			, {6077, 8, 1, 0}, {6077, 8, 2, 0}, {6077, 8, 3, 0}// 332	333	334	
			, {6077, 8, 4, 0}, {6077, 8, 5, 0}, {6077, 8, 6, 0}// 335	336	337	
			, {6077, 8, 7, 0}, {6077, 8, 8, 0}, {6077, 8, 9, 0}// 338	339	340	
			, {6077, 9, -8, 0}, {6077, 9, -7, 0}, {6077, 9, -6, 0}// 363	364	365	
			, {6077, 9, -5, 0}, {6077, 9, -4, 0}, {6077, 9, -3, 0}// 366	367	368	
			, {6077, 9, -2, 0}, {6077, 9, -1, 0}, {6077, 9, 0, 0}// 369	370	371	
			, {6077, 9, 1, 0}, {6077, 9, 2, 0}, {6077, 9, 3, 0}// 374	375	376	
			, {6077, 9, 4, 0}, {6077, 9, 5, 0}, {6077, 9, 6, 0}// 377	378	379	
			, {6077, 9, 7, 0}, {6077, 9, 8, 0}, {6077, 9, 9, 0}// 380	381	382	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new IceCaveWestfloorAddonDeed();
			}
		}

		[ Constructable ]
		public IceCaveWestfloorAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 609, -6, -8, 0, 2797, -1, "", 1);// 163
			AddComplexComponent( (BaseAddon) this, 609, -5, -8, 0, 2797, -1, "", 1);// 164
			AddComplexComponent( (BaseAddon) this, 609, -4, -8, 0, 2797, -1, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 609, -3, -8, 0, 2797, -1, "", 1);// 166
			AddComplexComponent( (BaseAddon) this, 609, -2, -8, 0, 2797, -1, "", 1);// 167
			AddComplexComponent( (BaseAddon) this, 609, -1, -8, 0, 2797, -1, "", 1);// 168
			AddComplexComponent( (BaseAddon) this, 609, 0, -8, 0, 2797, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 609, 1, -8, 0, 2797, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 609, 2, -8, 0, 2797, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 609, 3, -8, 0, 2797, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 609, 4, -8, 0, 2797, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 609, 5, -8, 0, 2797, -1, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 609, 6, -8, 0, 2797, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 609, 7, -8, 0, 2797, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 609, 8, -8, 0, 2797, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 608, -7, -7, 0, 2797, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 608, -7, -6, 0, 2797, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 608, -7, -5, 0, 2797, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 608, -7, -4, 0, 2797, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 608, -7, -3, 0, 2797, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 608, -7, -2, 0, 2797, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 608, -7, -1, 0, 2797, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 608, -7, 0, 0, 2797, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 610, -7, -8, 0, 2797, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 6926, 8, -6, 0, 2797, -1, "Frozen Bones", 1);// 187
			AddComplexComponent( (BaseAddon) this, 6924, -3, -4, 0, 2797, -1, "Frozen Bones", 1);// 188
			AddComplexComponent( (BaseAddon) this, 6093, 8, -5, 0, 2439, -1, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 6093, 1, 0, 0, 2439, -1, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 6093, 8, -7, 0, 2439, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 6093, 7, -6, 0, 2439, -1, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 6093, -4, -5, 0, 2439, -1, "", 1);// 193
			AddComplexComponent( (BaseAddon) this, 6093, -2, -3, 0, 2439, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 6093, -2, -5, 0, 2439, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 6093, -4, -3, 0, 2439, -1, "", 1);// 196
			AddComplexComponent( (BaseAddon) this, 608, -7, 1, 0, 2797, -1, "", 1);// 341
			AddComplexComponent( (BaseAddon) this, 608, -7, 2, 0, 2797, -1, "", 1);// 342
			AddComplexComponent( (BaseAddon) this, 608, -7, 3, 0, 2797, -1, "", 1);// 343
			AddComplexComponent( (BaseAddon) this, 608, -7, 4, 0, 2797, -1, "", 1);// 344
			AddComplexComponent( (BaseAddon) this, 608, -7, 5, 0, 2797, -1, "", 1);// 345
			AddComplexComponent( (BaseAddon) this, 608, -7, 6, 0, 2797, -1, "", 1);// 346
			AddComplexComponent( (BaseAddon) this, 608, -7, 7, 0, 2797, -1, "", 1);// 347
			AddComplexComponent( (BaseAddon) this, 608, -7, 8, 0, 2797, -1, "", 1);// 348
			AddComplexComponent( (BaseAddon) this, 608, -7, 9, 0, 2797, -1, "", 1);// 349
			AddComplexComponent( (BaseAddon) this, 6928, -5, 8, 0, 2797, -1, "Frozen Bones", 1);// 350
			AddComplexComponent( (BaseAddon) this, 6927, 1, 1, 0, 2797, -1, "Frozen Bones", 1);// 351
			AddComplexComponent( (BaseAddon) this, 6925, 6, 7, 0, 2797, -1, "Frozen Bones", 1);// 352
			AddComplexComponent( (BaseAddon) this, 6093, 7, 7, 0, 2439, -1, "", 1);// 353
			AddComplexComponent( (BaseAddon) this, 6093, 2, 1, 0, 2439, -1, "", 1);// 354
			AddComplexComponent( (BaseAddon) this, 6093, 1, 2, 0, 2439, -1, "", 1);// 355
			AddComplexComponent( (BaseAddon) this, 6093, 0, 1, 0, 2439, -1, "", 1);// 356
			AddComplexComponent( (BaseAddon) this, 6093, 6, 7, 0, 2439, -1, "", 1);// 357
			AddComplexComponent( (BaseAddon) this, 6093, 5, 7, 0, 2439, -1, "", 1);// 358
			AddComplexComponent( (BaseAddon) this, 6093, -6, 8, 0, 2439, -1, "", 1);// 359
			AddComplexComponent( (BaseAddon) this, 6093, -5, 9, 0, 2439, -1, "", 1);// 360
			AddComplexComponent( (BaseAddon) this, 6093, -4, 8, 0, 2439, -1, "", 1);// 361
			AddComplexComponent( (BaseAddon) this, 6093, -5, 7, 0, 2439, -1, "", 1);// 362
			AddComplexComponent( (BaseAddon) this, 609, 9, -8, 0, 2797, -1, "", 1);// 372
			AddComplexComponent( (BaseAddon) this, 6093, 9, -6, 0, 2439, -1, "", 1);// 373

		}

		public IceCaveWestfloorAddon( Serial serial ) : base( serial )
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

	public class IceCaveWestfloorAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new IceCaveWestfloorAddon();
			}
		}

		[Constructable]
		public IceCaveWestfloorAddonDeed()
		{
			Name = "IceCaveWestfloor";
		}

		public IceCaveWestfloorAddonDeed( Serial serial ) : base( serial )
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