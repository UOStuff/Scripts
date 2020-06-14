
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
	public class CustomSandstonePoolAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1824, -4, -8, 0}, {1824, -4, -7, 0}, {1824, -3, -8, 0}// 1	2	3	
			, {1824, -2, -8, 0}, {1824, -1, -8, 0}, {1824, 0, -8, 0}// 4	5	6	
			, {1824, 1, -8, 0}, {1182, -4, -8, 5}, {1182, -2, -8, 5}// 7	8	9	
			, {1182, 0, -8, 5}, {1395, -3, -8, 5}, {1395, -1, -8, 5}// 10	11	12	
			, {1395, 1, -8, 5}, {1395, -4, -7, 5}, {1294, -3, -7, 0}// 13	14	15	
			, {1294, -2, -7, 0}, {1294, -1, -7, 0}, {1294, 0, -7, 0}// 16	17	18	
			, {1294, 1, -7, 0}, {1914, -3, -7, 0}, {1824, -4, -6, 0}// 19	25	26	
			, {1824, -4, -5, 0}, {1824, -4, -4, 0}, {1824, -4, -3, 0}// 27	28	29	
			, {1824, -4, -2, 0}, {1824, -4, -1, 0}, {1824, -4, 0, 0}// 30	31	32	
			, {1824, -4, 1, 0}, {1824, -4, 2, 0}, {1824, -4, 3, 0}// 33	34	35	
			, {1824, -4, 4, 0}, {1824, -4, 5, 0}, {1824, -3, 4, 0}// 36	37	38	
			, {1824, -3, 5, 0}, {1824, -2, 4, 0}, {1824, -2, 5, 0}// 39	40	41	
			, {1824, -1, 4, 0}, {1824, -1, 5, 0}, {1824, 0, 4, 0}// 42	43	44	
			, {1824, 0, 5, 0}, {1824, 1, 4, 0}, {1824, 1, 5, 0}// 45	46	47	
			, {1824, -4, 6, 0}, {1824, -4, 7, 0}, {1824, -4, 8, 0}// 48	49	50	
			, {1824, -3, 6, 0}, {1824, -3, 7, 0}, {1824, -3, 8, 0}// 51	52	53	
			, {1824, -2, 6, 0}, {1824, -2, 7, 0}, {1824, -2, 8, 0}// 54	55	56	
			, {1824, -1, 6, 0}, {1824, -1, 7, 0}, {1824, -1, 8, 0}// 57	58	59	
			, {1824, 0, 6, 0}, {1824, 0, 7, 0}, {1824, 0, 8, 0}// 60	61	62	
			, {1824, 1, 6, 0}, {1824, 1, 7, 0}, {1824, 1, 8, 0}// 63	64	65	
			, {1182, -4, -6, 5}, {1182, -4, -4, 5}, {1182, -4, -2, 5}// 66	67	68	
			, {1182, -4, 0, 5}, {1182, -4, 2, 5}, {1182, -4, 4, 5}// 69	70	71	
			, {1182, -4, 6, 5}, {1182, -4, 8, 5}, {1182, -3, 5, 5}// 72	73	74	
			, {1182, -3, 7, 5}, {1182, -2, 4, 5}, {1182, -2, 6, 5}// 75	76	77	
			, {1182, -2, 8, 5}, {1182, -1, 5, 5}, {1182, -1, 7, 5}// 78	79	80	
			, {1182, 0, 4, 5}, {1182, 0, 6, 5}, {1182, 0, 8, 5}// 81	82	83	
			, {1182, 1, 5, 5}, {1182, 1, 7, 5}, {1395, 1, 4, 5}// 84	85	86	
			, {1395, -1, 4, 5}, {1395, -3, 4, 5}, {1395, -4, 3, 5}// 87	88	89	
			, {1395, -4, 1, 5}, {1395, -4, -1, 5}, {1395, -4, -3, 5}// 90	91	92	
			, {1395, -4, -5, 5}, {1395, -4, 5, 5}, {1395, -4, 7, 5}// 93	94	95	
			, {1395, -2, 5, 5}, {1395, 0, 5, 5}, {1395, -3, 6, 5}// 96	97	98	
			, {1395, -3, 8, 5}, {1395, -2, 7, 5}, {1395, -1, 6, 5}// 99	100	101	
			, {1395, 1, 6, 5}, {1395, 0, 7, 5}, {1395, -1, 8, 5}// 102	103	104	
			, {1395, 1, 8, 5}, {1294, -3, -6, 0}, {1294, -3, -5, 0}// 105	106	107	
			, {1294, -3, -4, 0}, {1294, -3, -3, 0}, {1294, -3, -2, 0}// 108	109	110	
			, {1294, -3, -1, 0}, {1294, -3, 0, 0}, {1294, -3, 1, 0}// 111	112	113	
			, {1294, -3, 3, 0}, {1294, -2, -6, 0}, {1294, -2, -5, 0}// 114	115	116	
			, {1294, -2, -4, 0}, {1294, -2, -3, 0}, {1294, -2, -2, 0}// 117	118	119	
			, {1294, -2, -1, 0}, {1294, -2, 0, 0}, {1294, -2, 1, 0}// 120	121	122	
			, {1294, -2, 3, 0}, {1294, -1, -6, 0}, {1294, -1, -5, 0}// 123	124	125	
			, {1294, -1, -4, 0}, {1294, -1, -3, 0}, {1294, -1, -2, 0}// 126	127	128	
			, {1294, -1, -1, 0}, {1294, -1, 0, 0}, {1294, -1, 1, 0}// 129	130	131	
			, {1294, -1, 3, 0}, {1294, 0, -6, 0}, {1294, 0, -5, 0}// 132	133	134	
			, {1294, 0, -4, 0}, {1294, 0, -3, 0}, {1294, 0, -2, 0}// 135	136	137	
			, {1294, 0, -1, 0}, {1294, 0, 0, 0}, {1294, 0, 1, 0}// 138	139	140	
			, {1294, 0, 3, 0}, {1294, 1, -6, 0}, {1294, 1, -5, 0}// 141	142	143	
			, {1294, 1, -4, 0}, {1294, 1, -3, 0}, {1294, 1, -2, 0}// 144	145	146	
			, {1294, 1, -1, 0}, {1294, 1, 0, 0}, {1294, 1, 1, 0}// 147	148	149	
			, {1294, 1, 3, 0}, {1294, -3, 2, 0}, {1294, -2, 2, 0}// 150	151	152	
			, {1294, -1, 2, 0}, {1294, 0, 2, 0}, {1294, 1, 2, 0}// 153	154	155	
			, {8656, -4, 8, 0}, {8656, -3, 8, 0}, {8656, -2, 8, 0}// 206	207	208	
			, {8656, -1, 8, 0}, {8656, 0, 8, 0}, {8656, 1, 8, 0}// 209	210	211	
			, {6018, 2, -8, 0}, {6019, 2, -8, 0}, {6020, 2, -8, 0}// 212	213	214	
			, {6021, 2, -8, 0}, {1824, 2, -8, 0}, {1824, 3, -8, 0}// 215	216	217	
			, {1824, 4, -8, 0}, {1824, 4, -7, 0}, {1182, 2, -8, 5}// 218	219	220	
			, {1182, 4, -8, 5}, {1395, 3, -8, 5}, {1395, 4, -7, 5}// 221	222	223	
			, {1294, 2, -7, 0}, {1294, 3, -7, 0}, {8654, 4, -8, 0}// 224	225	228	
			, {8654, 4, -7, 0}, {1824, 2, 4, 0}, {1824, 2, 5, 0}// 229	230	231	
			, {1824, 3, 4, 0}, {1824, 3, 5, 0}, {1824, 4, -6, 0}// 232	233	234	
			, {1824, 4, -5, 0}, {1824, 4, -4, 0}, {1824, 4, -3, 0}// 235	236	237	
			, {1824, 4, -2, 0}, {1824, 4, -1, 0}, {1824, 4, 0, 0}// 238	239	240	
			, {1824, 4, 1, 0}, {1824, 4, 2, 0}, {1824, 4, 3, 0}// 241	242	243	
			, {1824, 4, 4, 0}, {1824, 4, 5, 0}, {1824, 2, 6, 0}// 244	245	246	
			, {1824, 2, 7, 0}, {1824, 2, 8, 0}, {1824, 3, 6, 0}// 247	248	249	
			, {1824, 3, 7, 0}, {1824, 3, 8, 0}, {1824, 4, 6, 0}// 250	251	252	
			, {1824, 4, 7, 0}, {1824, 4, 8, 0}, {1182, 2, 4, 5}// 253	254	255	
			, {1182, 2, 6, 5}, {1182, 2, 8, 5}, {1182, 3, 5, 5}// 256	257	258	
			, {1182, 3, 7, 5}, {1182, 4, 4, 5}, {1182, 4, 6, 5}// 259	260	261	
			, {1182, 4, 8, 5}, {1182, 4, 2, 5}, {1182, 4, 0, 5}// 262	263	264	
			, {1182, 4, -2, 5}, {1182, 4, -4, 5}, {1182, 4, -6, 5}// 265	266	267	
			, {1395, 4, -5, 5}, {1395, 4, -3, 5}, {1395, 4, -1, 5}// 268	269	270	
			, {1395, 4, 1, 5}, {1395, 4, 3, 5}, {1395, 3, 4, 5}// 271	272	273	
			, {1395, 2, 5, 5}, {1395, 4, 5, 5}, {1395, 3, 6, 5}// 274	275	276	
			, {1395, 2, 7, 5}, {1395, 4, 7, 5}, {1395, 3, 8, 5}// 277	278	279	
			, {1294, 2, -6, 0}, {1294, 2, -5, 0}, {1294, 2, -4, 0}// 280	281	282	
			, {1294, 2, -3, 0}, {1294, 2, -2, 0}, {1294, 2, -1, 0}// 283	284	285	
			, {1294, 2, 0, 0}, {1294, 2, 1, 0}, {1294, 2, 3, 0}// 286	287	288	
			, {1294, 3, -6, 0}, {1294, 3, -5, 0}, {1294, 3, -4, 0}// 289	290	291	
			, {1294, 3, -3, 0}, {1294, 3, -2, 0}, {1294, 3, -1, 0}// 292	293	294	
			, {1294, 3, 0, 0}, {1294, 3, 1, 0}, {1294, 3, 3, 0}// 295	296	297	
			, {1294, 2, 2, 0}, {1294, 3, 2, 0}, {8656, 4, 8, 0}// 298	299	320	
			, {8656, 2, 8, 0}, {8656, 3, 8, 0}, {8654, 4, -6, 0}// 321	322	323	
			, {8654, 4, -5, 0}, {8654, 4, -4, 0}, {8654, 4, -3, 0}// 324	325	326	
			, {8654, 4, -2, 0}, {8654, 4, -1, 0}, {8654, 4, 0, 0}// 327	328	329	
			, {8654, 4, 1, 0}, {8654, 4, 2, 0}, {8654, 4, 3, 0}// 330	331	332	
			, {8654, 4, 4, 0}, {8654, 4, 5, 0}, {8654, 4, 6, 0}// 333	334	335	
			, {8654, 4, 7, 0}, {8654, 4, 8, 0}, {1913, 3, 3, 0}// 336	337	338	
			, {1902, 5, 6, 0}, {1902, 5, 7, 0}, {1906, 5, 8, 0}// 339	340	341	
			, {1907, 5, 5, 0}// 342	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CustomSandstonePoolAddonDeed();
			}
		}

		[ Constructable ]
		public CustomSandstonePoolAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 7385, -3, -7, 5, 90, -1, "Water", 1);// 20
			AddComplexComponent( (BaseAddon) this, 7385, -2, -7, 5, 90, -1, "Water", 1);// 21
			AddComplexComponent( (BaseAddon) this, 7385, -1, -7, 5, 90, -1, "Water", 1);// 22
			AddComplexComponent( (BaseAddon) this, 7385, 0, -7, 5, 90, -1, "Water", 1);// 23
			AddComplexComponent( (BaseAddon) this, 7385, 1, -7, 5, 90, -1, "Water", 1);// 24
			AddComplexComponent( (BaseAddon) this, 7385, -3, -6, 5, 90, -1, "Water", 1);// 156
			AddComplexComponent( (BaseAddon) this, 7385, -3, -5, 5, 90, -1, "Water", 1);// 157
			AddComplexComponent( (BaseAddon) this, 7385, -3, -4, 5, 90, -1, "Water", 1);// 158
			AddComplexComponent( (BaseAddon) this, 7385, -3, -3, 5, 90, -1, "Water", 1);// 159
			AddComplexComponent( (BaseAddon) this, 7385, -3, -2, 5, 90, -1, "Water", 1);// 160
			AddComplexComponent( (BaseAddon) this, 7385, -3, -1, 5, 90, -1, "Water", 1);// 161
			AddComplexComponent( (BaseAddon) this, 7385, -3, 0, 5, 90, -1, "Water", 1);// 162
			AddComplexComponent( (BaseAddon) this, 7385, -3, 1, 5, 90, -1, "Water", 1);// 163
			AddComplexComponent( (BaseAddon) this, 7385, -3, 2, 5, 90, -1, "Water", 1);// 164
			AddComplexComponent( (BaseAddon) this, 7385, -3, 3, 5, 90, -1, "Water", 1);// 165
			AddComplexComponent( (BaseAddon) this, 7385, -2, -6, 5, 90, -1, "Water", 1);// 166
			AddComplexComponent( (BaseAddon) this, 7385, -2, -5, 5, 90, -1, "Water", 1);// 167
			AddComplexComponent( (BaseAddon) this, 7385, -2, -4, 5, 90, -1, "Water", 1);// 168
			AddComplexComponent( (BaseAddon) this, 7385, -2, -3, 5, 90, -1, "Water", 1);// 169
			AddComplexComponent( (BaseAddon) this, 7385, -2, -2, 5, 90, -1, "Water", 1);// 170
			AddComplexComponent( (BaseAddon) this, 7385, -2, -1, 5, 90, -1, "Water", 1);// 171
			AddComplexComponent( (BaseAddon) this, 7385, -2, 0, 5, 90, -1, "Water", 1);// 172
			AddComplexComponent( (BaseAddon) this, 7385, -2, 1, 5, 90, -1, "Water", 1);// 173
			AddComplexComponent( (BaseAddon) this, 7385, -2, 2, 5, 90, -1, "Water", 1);// 174
			AddComplexComponent( (BaseAddon) this, 7385, -2, 3, 5, 90, -1, "Water", 1);// 175
			AddComplexComponent( (BaseAddon) this, 7385, -1, -6, 5, 90, -1, "Water", 1);// 176
			AddComplexComponent( (BaseAddon) this, 7385, -1, -5, 5, 90, -1, "Water", 1);// 177
			AddComplexComponent( (BaseAddon) this, 7385, -1, -4, 5, 90, -1, "Water", 1);// 178
			AddComplexComponent( (BaseAddon) this, 7385, -1, -3, 5, 90, -1, "Water", 1);// 179
			AddComplexComponent( (BaseAddon) this, 7385, -1, -2, 5, 90, -1, "Water", 1);// 180
			AddComplexComponent( (BaseAddon) this, 7385, -1, -1, 5, 90, -1, "Water", 1);// 181
			AddComplexComponent( (BaseAddon) this, 7385, -1, 0, 5, 90, -1, "Water", 1);// 182
			AddComplexComponent( (BaseAddon) this, 7385, -1, 1, 5, 90, -1, "Water", 1);// 183
			AddComplexComponent( (BaseAddon) this, 7385, -1, 2, 5, 90, -1, "Water", 1);// 184
			AddComplexComponent( (BaseAddon) this, 7385, -1, 3, 5, 90, -1, "Water", 1);// 185
			AddComplexComponent( (BaseAddon) this, 7385, 0, -6, 5, 90, -1, "Water", 1);// 186
			AddComplexComponent( (BaseAddon) this, 7385, 0, -5, 5, 90, -1, "Water", 1);// 187
			AddComplexComponent( (BaseAddon) this, 7385, 0, -4, 5, 90, -1, "Water", 1);// 188
			AddComplexComponent( (BaseAddon) this, 7385, 0, -3, 5, 90, -1, "Water", 1);// 189
			AddComplexComponent( (BaseAddon) this, 7385, 0, -2, 5, 90, -1, "Water", 1);// 190
			AddComplexComponent( (BaseAddon) this, 7385, 0, -1, 5, 90, -1, "Water", 1);// 191
			AddComplexComponent( (BaseAddon) this, 7385, 0, 0, 5, 90, -1, "Water", 1);// 192
			AddComplexComponent( (BaseAddon) this, 7385, 0, 1, 5, 90, -1, "Water", 1);// 193
			AddComplexComponent( (BaseAddon) this, 7385, 0, 2, 5, 90, -1, "Water", 1);// 194
			AddComplexComponent( (BaseAddon) this, 7385, 0, 3, 5, 90, -1, "Water", 1);// 195
			AddComplexComponent( (BaseAddon) this, 7385, 1, -6, 5, 90, -1, "Water", 1);// 196
			AddComplexComponent( (BaseAddon) this, 7385, 1, -5, 5, 90, -1, "Water", 1);// 197
			AddComplexComponent( (BaseAddon) this, 7385, 1, -4, 5, 90, -1, "Water", 1);// 198
			AddComplexComponent( (BaseAddon) this, 7385, 1, -3, 5, 90, -1, "Water", 1);// 199
			AddComplexComponent( (BaseAddon) this, 7385, 1, -2, 5, 90, -1, "Water", 1);// 200
			AddComplexComponent( (BaseAddon) this, 7385, 1, -1, 5, 90, -1, "Water", 1);// 201
			AddComplexComponent( (BaseAddon) this, 7385, 1, 0, 5, 90, -1, "Water", 1);// 202
			AddComplexComponent( (BaseAddon) this, 7385, 1, 1, 5, 90, -1, "Water", 1);// 203
			AddComplexComponent( (BaseAddon) this, 7385, 1, 2, 5, 90, -1, "Water", 1);// 204
			AddComplexComponent( (BaseAddon) this, 7385, 1, 3, 5, 90, -1, "Water", 1);// 205
			AddComplexComponent( (BaseAddon) this, 7385, 2, -7, 5, 90, -1, "Water", 1);// 226
			AddComplexComponent( (BaseAddon) this, 7385, 3, -7, 5, 90, -1, "Water", 1);// 227
			AddComplexComponent( (BaseAddon) this, 7385, 2, -6, 5, 90, -1, "Water", 1);// 300
			AddComplexComponent( (BaseAddon) this, 7385, 2, -5, 5, 90, -1, "Water", 1);// 301
			AddComplexComponent( (BaseAddon) this, 7385, 2, -4, 5, 90, -1, "Water", 1);// 302
			AddComplexComponent( (BaseAddon) this, 7385, 2, -3, 5, 90, -1, "Water", 1);// 303
			AddComplexComponent( (BaseAddon) this, 7385, 2, -2, 5, 90, -1, "Water", 1);// 304
			AddComplexComponent( (BaseAddon) this, 7385, 2, -1, 5, 90, -1, "Water", 1);// 305
			AddComplexComponent( (BaseAddon) this, 7385, 2, 0, 5, 90, -1, "Water", 1);// 306
			AddComplexComponent( (BaseAddon) this, 7385, 2, 1, 5, 90, -1, "Water", 1);// 307
			AddComplexComponent( (BaseAddon) this, 7385, 2, 2, 5, 90, -1, "Water", 1);// 308
			AddComplexComponent( (BaseAddon) this, 7385, 2, 3, 5, 90, -1, "Water", 1);// 309
			AddComplexComponent( (BaseAddon) this, 7385, 3, -6, 5, 90, -1, "Water", 1);// 310
			AddComplexComponent( (BaseAddon) this, 7385, 3, -5, 5, 90, -1, "Water", 1);// 311
			AddComplexComponent( (BaseAddon) this, 7385, 3, -4, 5, 90, -1, "Water", 1);// 312
			AddComplexComponent( (BaseAddon) this, 7385, 3, -3, 5, 90, -1, "Water", 1);// 313
			AddComplexComponent( (BaseAddon) this, 7385, 3, -2, 5, 90, -1, "Water", 1);// 314
			AddComplexComponent( (BaseAddon) this, 7385, 3, -1, 5, 90, -1, "Water", 1);// 315
			AddComplexComponent( (BaseAddon) this, 7385, 3, 0, 5, 90, -1, "Water", 1);// 316
			AddComplexComponent( (BaseAddon) this, 7385, 3, 1, 5, 90, -1, "Water", 1);// 317
			AddComplexComponent( (BaseAddon) this, 7385, 3, 2, 5, 90, -1, "Water", 1);// 318
			AddComplexComponent( (BaseAddon) this, 7385, 3, 3, 5, 90, -1, "Water", 1);// 319

		}

		public CustomSandstonePoolAddon( Serial serial ) : base( serial )
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

	public class CustomSandstonePoolAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CustomSandstonePoolAddon();
			}
		}

		[Constructable]
		public CustomSandstonePoolAddonDeed()
		{
			Name = "CustomSandstonePool";
		}

		public CustomSandstonePoolAddonDeed( Serial serial ) : base( serial )
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