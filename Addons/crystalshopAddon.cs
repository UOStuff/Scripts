
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
	public class crystalshopAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1801, -4, -6, 0}, {1801, -4, -5, 0}, {1801, -4, -4, 0}// 1	2	3	
			, {1801, -4, -3, 0}, {1801, -3, -6, 0}, {1801, -3, -5, 0}// 4	5	6	
			, {1801, -3, -4, 0}, {1801, -3, -3, 0}, {1801, -2, -6, 0}// 7	8	9	
			, {1801, -2, -5, 0}, {1801, -2, -4, 0}, {1801, -2, -3, 0}// 10	11	12	
			, {1801, -1, -6, 0}, {1801, -1, -5, 0}, {1801, -1, -3, 0}// 13	14	15	
			, {1801, -1, -4, 0}, {13746, -4, -6, 25}, {13746, -4, -5, 25}// 28	29	30	
			, {13746, -4, -4, 25}, {13746, -4, -3, 25}, {13746, -3, -6, 25}// 31	32	33	
			, {13746, -3, -5, 25}, {13746, -3, -4, 25}, {13746, -3, -3, 25}// 34	35	36	
			, {13746, -2, -6, 25}, {13746, -2, -5, 25}, {13746, -2, -4, 25}// 37	38	39	
			, {13746, -2, -3, 25}, {13746, -1, -6, 25}, {13746, -1, -5, 25}// 40	41	42	
			, {13746, -1, -4, 25}, {13746, -1, -3, 25}, {1801, -4, -2, 0}// 43	44	52	
			, {1801, -4, -1, 0}, {1801, -4, 0, 0}, {1801, -4, 1, 0}// 53	54	55	
			, {1801, -4, 2, 0}, {1801, -3, -2, 0}, {1801, -3, -1, 0}// 56	57	58	
			, {1801, -3, 0, 0}, {1801, -3, 1, 0}, {1801, -3, 2, 0}// 59	60	61	
			, {1801, -2, -2, 0}, {1801, -2, -1, 0}, {1801, -2, 0, 0}// 62	63	64	
			, {1801, -2, 1, 0}, {1801, -2, 2, 0}, {1801, -1, -2, 0}// 65	66	67	
			, {1801, -1, -1, 0}, {1801, -1, 0, 0}, {1801, -1, 1, 0}// 68	69	70	
			, {1801, -1, 2, 0}, {1801, -4, 3, 0}, {1801, -4, 4, 0}// 71	72	73	
			, {1801, -4, 5, 0}, {1801, -4, 6, 0}, {1801, -3, 3, 0}// 74	75	76	
			, {1801, -3, 4, 0}, {1801, -3, 5, 0}, {1801, -3, 6, 0}// 77	78	79	
			, {1801, -2, 3, 0}, {1801, -2, 4, 0}, {1801, -2, 5, 0}// 80	81	82	
			, {1801, -2, 6, 0}, {1801, -1, 3, 0}, {1801, -1, 4, 0}// 83	84	85	
			, {1801, -1, 5, 0}, {1801, -1, 6, 0}, {13746, -4, -2, 25}// 86	87	102	
			, {13746, -4, -1, 25}, {13746, -4, 0, 25}, {13746, -4, 1, 25}// 103	104	105	
			, {13746, -4, 2, 25}, {13746, -4, 3, 25}, {13746, -4, 4, 25}// 106	107	108	
			, {13746, -4, 5, 25}, {13746, -4, 6, 25}, {13746, -3, -2, 25}// 109	110	111	
			, {13746, -3, -1, 25}, {13746, -3, 0, 25}, {13746, -3, 1, 25}// 112	113	114	
			, {13746, -3, 2, 25}, {13746, -3, 3, 25}, {13746, -3, 4, 25}// 115	116	117	
			, {13746, -3, 5, 25}, {13746, -3, 6, 25}, {13746, -2, -2, 25}// 118	119	120	
			, {13746, -2, -1, 25}, {13746, -2, 0, 25}, {13746, -2, 1, 25}// 121	122	123	
			, {13746, -2, 2, 25}, {13746, -2, 3, 25}, {13746, -2, 4, 25}// 124	125	126	
			, {13746, -2, 5, 25}, {13746, -2, 6, 25}, {13746, -1, -2, 25}// 127	128	129	
			, {13746, -1, -1, 25}, {13746, -1, 0, 25}, {13746, -1, 1, 25}// 130	131	132	
			, {13746, -1, 2, 25}, {13746, -1, 3, 25}, {13746, -1, 4, 25}// 133	134	135	
			, {13746, -1, 5, 25}, {13746, -1, 6, 25}, {1801, 0, -6, 0}// 136	137	148	
			, {1801, 0, -5, 0}, {1801, 0, -3, 0}, {1801, 1, -6, 0}// 149	150	151	
			, {1801, 1, -5, 0}, {1801, 1, -4, 0}, {1801, 1, -3, 0}// 152	153	154	
			, {1801, 2, -6, 0}, {1801, 2, -5, 0}, {1801, 2, -4, 0}// 155	156	157	
			, {1801, 2, -3, 0}, {1801, 3, -6, 0}, {1801, 3, -5, 0}// 158	159	160	
			, {1801, 3, -4, 0}, {1801, 3, -3, 0}, {1801, 4, -6, 0}// 161	162	163	
			, {1801, 4, -5, 0}, {1801, 4, -4, 0}, {1801, 4, -3, 0}// 164	165	166	
			, {1801, 5, -6, 0}, {1801, 5, -5, 0}, {1801, 5, -4, 0}// 167	168	169	
			, {1801, 5, -3, 0}, {1801, 6, -6, 0}, {1801, 6, -5, 0}// 170	171	172	
			, {1801, 6, -4, 0}, {1801, 6, -3, 0}, {1801, 0, -4, 0}// 173	174	186	
			, {13746, 0, -6, 25}, {13746, 0, -5, 25}, {13746, 0, -4, 25}// 187	188	189	
			, {13746, 0, -3, 25}, {13746, 1, -6, 25}, {13746, 1, -5, 25}// 190	191	192	
			, {13746, 1, -4, 25}, {13746, 1, -3, 25}, {13746, 2, -6, 25}// 193	194	195	
			, {13746, 2, -5, 25}, {13746, 2, -4, 25}, {13746, 2, -3, 25}// 196	197	198	
			, {13746, 3, -6, 25}, {13746, 3, -5, 25}, {13746, 3, -4, 25}// 199	200	201	
			, {13746, 3, -3, 25}, {13746, 4, -6, 25}, {13746, 4, -5, 25}// 202	203	204	
			, {13746, 4, -4, 25}, {13746, 4, -3, 25}, {13746, 5, -6, 25}// 205	206	207	
			, {13746, 5, -5, 25}, {13746, 5, -4, 25}, {13746, 5, -3, 25}// 208	209	210	
			, {13746, 6, -6, 25}, {13746, 6, -5, 25}, {13746, 6, -4, 25}// 211	212	213	
			, {13746, 6, -3, 25}, {1801, 0, -1, 0}, {1801, 0, 0, 0}// 214	223	224	
			, {1801, 0, 1, 0}, {1801, 0, 2, 0}, {1801, 1, -2, 0}// 225	226	227	
			, {1801, 1, -1, 0}, {1801, 1, 0, 0}, {1801, 1, 1, 0}// 228	229	230	
			, {1801, 1, 2, 0}, {1801, 2, -2, 0}, {1801, 2, -1, 0}// 231	232	233	
			, {1801, 2, 0, 0}, {1801, 2, 1, 0}, {1801, 2, 2, 0}// 234	235	236	
			, {1801, 3, -2, 0}, {1801, 3, -1, 0}, {1801, 3, 0, 0}// 237	238	239	
			, {1801, 3, 1, 0}, {1801, 3, 2, 0}, {1801, 4, -2, 0}// 240	241	242	
			, {1801, 4, -1, 0}, {1801, 4, 0, 0}, {1801, 4, 1, 0}// 243	244	245	
			, {1801, 4, 2, 0}, {1801, 5, -2, 0}, {1801, 5, -1, 0}// 246	247	248	
			, {1801, 5, 0, 0}, {1801, 5, 1, 0}, {1801, 5, 2, 0}// 249	250	251	
			, {1801, 6, -2, 0}, {1801, 6, -1, 0}, {1801, 6, 0, 0}// 252	253	254	
			, {1801, 6, 1, 0}, {1801, 6, 2, 0}, {1801, 0, 3, 0}// 255	256	257	
			, {1801, 0, 4, 0}, {1801, 0, 5, 0}, {1801, 0, 6, 0}// 258	259	260	
			, {1801, 1, 3, 0}, {1801, 1, 4, 0}, {1801, 1, 5, 0}// 261	262	263	
			, {1801, 1, 6, 0}, {1801, 2, 3, 0}, {1801, 2, 4, 0}// 264	265	266	
			, {1801, 2, 5, 0}, {1801, 2, 6, 0}, {1801, 3, 3, 0}// 267	268	269	
			, {1801, 3, 4, 0}, {1801, 3, 5, 0}, {1801, 3, 6, 0}// 270	271	272	
			, {1801, 4, 3, 0}, {1801, 4, 4, 0}, {1801, 4, 5, 0}// 273	274	275	
			, {1801, 4, 6, 0}, {1801, 5, 3, 0}, {1801, 5, 4, 0}// 276	277	278	
			, {1801, 5, 5, 0}, {1801, 5, 6, 0}, {1801, 6, 6, 0}// 279	280	281	
			, {1803, 6, 3, 0}, {1803, 6, 4, 0}, {1803, 6, 5, 0}// 282	283	284	
			, {1801, 0, -2, 0}, {13746, 0, -2, 25}, {13746, 0, -1, 25}// 300	301	302	
			, {13746, 0, 0, 25}, {13746, 0, 1, 25}, {13746, 0, 2, 25}// 303	304	305	
			, {13746, 0, 3, 25}, {13746, 0, 4, 25}, {13746, 0, 5, 25}// 306	307	308	
			, {13746, 0, 6, 25}, {13746, 1, -2, 25}, {13746, 1, -1, 25}// 309	310	311	
			, {13746, 1, 0, 25}, {13746, 1, 1, 25}, {13746, 1, 2, 25}// 312	313	314	
			, {13746, 1, 3, 25}, {13746, 1, 4, 25}, {13746, 1, 5, 25}// 315	316	317	
			, {13746, 1, 6, 25}, {13746, 2, -2, 25}, {13746, 2, -1, 25}// 318	319	320	
			, {13746, 2, 0, 25}, {13746, 2, 1, 25}, {13746, 2, 2, 25}// 321	322	323	
			, {13746, 2, 3, 25}, {13746, 2, 4, 25}, {13746, 2, 5, 25}// 324	325	326	
			, {13746, 2, 6, 25}, {13746, 3, -2, 25}, {13746, 3, -1, 25}// 327	328	329	
			, {13746, 3, 0, 25}, {13746, 3, 1, 25}, {13746, 3, 2, 25}// 330	331	332	
			, {13746, 3, 3, 25}, {13746, 3, 4, 25}, {13746, 3, 5, 25}// 333	334	335	
			, {13746, 3, 6, 25}, {13746, 4, -2, 25}, {13746, 4, -1, 25}// 336	337	338	
			, {13746, 4, 0, 25}, {13746, 4, 1, 25}, {13746, 4, 2, 25}// 339	340	341	
			, {13746, 4, 3, 25}, {13746, 4, 4, 25}, {13746, 4, 5, 25}// 342	343	344	
			, {13746, 4, 6, 25}, {13746, 5, -2, 25}, {13746, 5, -1, 25}// 345	346	347	
			, {13746, 5, 0, 25}, {13746, 5, 1, 25}, {13746, 5, 2, 25}// 348	349	350	
			, {13746, 5, 3, 25}, {13746, 5, 4, 25}, {13746, 5, 5, 25}// 351	352	353	
			, {13746, 5, 6, 25}, {13746, 6, -2, 25}, {13746, 6, -1, 25}// 354	355	356	
			, {13746, 6, 0, 25}, {13746, 6, 1, 25}, {13746, 6, 2, 25}// 357	358	359	
			, {13746, 6, 3, 25}, {13746, 6, 4, 25}, {13746, 6, 5, 25}// 360	361	362	
			, {13746, 6, 6, 25}// 363	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new crystalshopAddonDeed();
			}
		}

		[ Constructable ]
		public crystalshopAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 10384, -5, -6, 5, 2400, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 10387, -4, -7, 5, 2400, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 10381, -5, -7, 5, 89, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 10382, -5, -6, 25, 89, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 10382, -5, -5, 25, 89, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 10382, -5, -4, 25, 89, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 10382, -5, -3, 25, 89, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 10385, -4, -7, 25, 89, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 10385, -3, -7, 25, 89, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 10385, -2, -7, 25, 89, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 10385, -1, -7, 25, 89, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 10401, -5, -7, 25, 89, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 10384, -5, -5, 5, 2400, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 10384, -5, -4, 5, 2400, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 10384, -5, -3, 5, 2400, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 10387, -4, -7, 5, 2400, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 10387, -3, -7, 5, 2400, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 10387, -2, -7, 5, 2400, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 10387, -1, -7, 5, 2400, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 10384, -5, 6, 5, 2400, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 10382, -5, -2, 25, 89, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 10382, -5, -1, 25, 89, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 10382, -5, 0, 25, 89, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 10382, -5, 1, 25, 89, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 10382, -5, 2, 25, 89, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 10382, -5, 3, 25, 89, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 10382, -5, 4, 25, 89, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 10382, -5, 5, 25, 89, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 10382, -5, 6, 25, 89, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 10385, -4, 6, 25, 89, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 10385, -3, 6, 25, 89, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 10385, -2, 6, 25, 89, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 10387, -4, 6, 6, 2400, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 10384, -5, -2, 5, 2400, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 10384, -5, -1, 5, 2400, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 10384, -5, 0, 5, 2400, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 10384, -5, 1, 5, 2400, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 10384, -5, 2, 5, 2400, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 10384, -5, 3, 5, 2400, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 10384, -5, 4, 5, 2400, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 10384, -5, 5, 5, 2400, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 2210, -1, 8, 1, 2400, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 2212, -1, 7, 11, 2400, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 10382, 6, -6, 25, 89, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 10382, 6, -5, 25, 89, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 10382, 6, -4, 25, 89, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 10382, 6, -3, 25, 89, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 10385, 0, -7, 25, 89, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 10385, 1, -7, 25, 89, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 10385, 2, -7, 25, 89, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 10385, 3, -7, 25, 89, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 10385, 4, -7, 25, 89, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 10385, 5, -7, 25, 89, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 10385, 6, -7, 25, 89, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 10387, 0, -7, 5, 2400, -1, "", 1);// 215
			AddComplexComponent( (BaseAddon) this, 10387, 0, -7, 5, 2400, -1, "", 1);// 216
			AddComplexComponent( (BaseAddon) this, 10387, 1, -7, 5, 2400, -1, "", 1);// 217
			AddComplexComponent( (BaseAddon) this, 10387, 2, -7, 5, 2400, -1, "", 1);// 218
			AddComplexComponent( (BaseAddon) this, 10387, 3, -7, 5, 2400, -1, "", 1);// 219
			AddComplexComponent( (BaseAddon) this, 10387, 4, -7, 5, 2400, -1, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 10387, 5, -7, 5, 2400, -1, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 10387, 6, -7, 5, 2400, -1, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 10403, 6, 6, 5, 2400, -1, "", 1);// 285
			AddComplexComponent( (BaseAddon) this, 10382, 6, -2, 25, 89, -1, "", 1);// 286
			AddComplexComponent( (BaseAddon) this, 10382, 6, -1, 25, 89, -1, "", 1);// 287
			AddComplexComponent( (BaseAddon) this, 10382, 6, 0, 25, 89, -1, "", 1);// 288
			AddComplexComponent( (BaseAddon) this, 10382, 6, 1, 25, 89, -1, "", 1);// 289
			AddComplexComponent( (BaseAddon) this, 10382, 6, 2, 25, 89, -1, "", 1);// 290
			AddComplexComponent( (BaseAddon) this, 10382, 6, 3, 25, 89, -1, "", 1);// 291
			AddComplexComponent( (BaseAddon) this, 10382, 6, 4, 25, 89, -1, "", 1);// 292
			AddComplexComponent( (BaseAddon) this, 10382, 6, 5, 25, 89, -1, "", 1);// 293
			AddComplexComponent( (BaseAddon) this, 10376, 6, 6, 25, 89, -1, "", 1);// 294
			AddComplexComponent( (BaseAddon) this, 10385, 1, 6, 25, 89, -1, "", 1);// 295
			AddComplexComponent( (BaseAddon) this, 10385, 2, 6, 25, 89, -1, "", 1);// 296
			AddComplexComponent( (BaseAddon) this, 10385, 3, 6, 25, 89, -1, "", 1);// 297
			AddComplexComponent( (BaseAddon) this, 10385, 4, 6, 25, 89, -1, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 10385, 5, 6, 25, 89, -1, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 10385, 0, 6, 25, 89, -1, "", 1);// 364

		}

		public crystalshopAddon( Serial serial ) : base( serial )
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

	public class crystalshopAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new crystalshopAddon();
			}
		}

		[Constructable]
		public crystalshopAddonDeed()
		{
			Name = "crystalshop";
		}

		public crystalshopAddonDeed( Serial serial ) : base( serial )
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