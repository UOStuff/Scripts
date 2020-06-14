
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
	public class kidtownpondAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10298, -5, 0, 1}, {3255, -7, -5, 0}, {3255, -8, -3, 0}// 6	7	8	
			, {3255, -6, -7, 0}, {3255, -9, 0, 10}, {3219, -9, 1, 0}// 9	10	57	
			, {3220, -7, 6, 1}, {3209, -8, 4, 0}, {3225, -9, 2, 0}// 58	59	79	
			, {3228, -9, 2, 0}, {3671, -10, 3, 0}, {10298, 4, 0, 1}// 80	81	121	
			, {3219, -1, -10, 1}, {3219, 8, -4, 1}, {3220, 4, -8, 1}// 122	123	124	
			, {3209, 2, -9, 1}, {3518, -3, -2, 1}, {3518, 3, -6, 1}// 125	126	127	
			, {3255, -3, -7, 10}, {3255, -1, 0, 1}, {3255, -2, -9, 0}// 128	187	221	
			, {3255, 1, -10, 0}, {3239, 10, -1, 1}, {3239, 5, -7, 1}// 222	223	224	
			, {3225, 3, -9, 0}, {3228, 4, -9, 0}, {3219, -1, 9, 0}// 225	227	297	
			, {3219, 7, 6, 1}, {3220, 8, 3, 1}, {3220, 3, 9, 1}// 298	299	300	
			, {3209, 8, 5, 1}, {3209, -4, 8, 1}, {3518, 3, 5, 1}// 301	302	303	
			, {3225, -2, 9, 0}, {3225, 9, 2, 0}, {3226, 10, 2, 0}// 351	352	353	
			, {3228, 10, 2, 0}, {3228, -2, 9, 0}, {3229, 2, 10, 0}// 354	355	356	
			, {3227, 1, 10, 0}// 357	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new kidtownpondAddonDeed();
			}
		}

		[ Constructable ]
		public kidtownpondAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6051, -7, -6, 0, 0, -1, "(12,6051): -7, -6, 0", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6054, -7, -7, 0, 0, -1, "(13,6054): -7, -7, 0", 1);// 2
			AddComplexComponent( (BaseAddon) this, 6054, -8, -5, 0, 0, -1, "(14,6054): -8, -5, 0", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6060, -7, -5, 0, 0, -1, "(15,6060): -7, -5, 0", 1);// 4
			AddComplexComponent( (BaseAddon) this, 10301, -5, -4, 1, 2562, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 6051, -8, -4, 0, 0, -1, "(54,6051): -8, -4, 0", 1);// 11
			AddComplexComponent( (BaseAddon) this, 6039, -7, -4, 0, 0, -1, "(71,6039): -7, -4, 0", 1);// 12
			AddComplexComponent( (BaseAddon) this, 6054, -9, -3, 0, 0, -1, "(60,6054): -9, -3, 0", 1);// 13
			AddComplexComponent( (BaseAddon) this, 6060, -8, -3, 0, 0, -1, "(69,6060): -8, -3, 0", 1);// 14
			AddComplexComponent( (BaseAddon) this, 6039, -7, -3, 0, 0, -1, "(72,6039): -7, -3, 0", 1);// 15
			AddComplexComponent( (BaseAddon) this, 6051, -9, -2, 0, 0, -1, "(55,6051): -9, -2, 0", 1);// 16
			AddComplexComponent( (BaseAddon) this, 6039, -7, -2, 0, 0, -1, "(73,6039): -7, -2, 0", 1);// 17
			AddComplexComponent( (BaseAddon) this, 6039, -8, -2, 0, 0, -1, "(80,6039): -8, -2, 0", 1);// 18
			AddComplexComponent( (BaseAddon) this, 6054, -10, -1, 0, 0, -1, "(61,6054): -10, -1, 0", 1);// 19
			AddComplexComponent( (BaseAddon) this, 6060, -9, -1, 0, 0, -1, "(70,6060): -9, -1, 0", 1);// 20
			AddComplexComponent( (BaseAddon) this, 6039, -7, -1, 0, 0, -1, "(74,6039): -7, -1, 0", 1);// 21
			AddComplexComponent( (BaseAddon) this, 6039, -8, -1, 0, 0, -1, "(81,6039): -8, -1, 0", 1);// 22
			AddComplexComponent( (BaseAddon) this, 6039, -6, -6, 0, 0, -1, "(1,6039): -6, -6, 0", 1);// 23
			AddComplexComponent( (BaseAddon) this, 6039, -6, -5, 0, 0, -1, "(2,6039): -6, -5, 0", 1);// 24
			AddComplexComponent( (BaseAddon) this, 6047, -6, -7, 0, 0, -1, "(7,6047): -6, -7, 0", 1);// 25
			AddComplexComponent( (BaseAddon) this, 6039, -6, -4, 0, 0, -1, "(16,6039): -6, -4, 0", 1);// 26
			AddComplexComponent( (BaseAddon) this, 6039, -6, -3, 0, 0, -1, "(17,6039): -6, -3, 0", 1);// 27
			AddComplexComponent( (BaseAddon) this, 6039, -6, -2, 0, 0, -1, "(20,6039): -6, -2, 0", 1);// 28
			AddComplexComponent( (BaseAddon) this, 6039, -6, -1, 0, 0, -1, "(25,6039): -6, -1, 0", 1);// 29
			AddComplexComponent( (BaseAddon) this, 6039, -5, -6, 0, 0, -1, "(3,6039): -5, -6, 0", 1);// 30
			AddComplexComponent( (BaseAddon) this, 6039, -5, -5, 0, 0, -1, "(4,6039): -5, -5, 0", 1);// 31
			AddComplexComponent( (BaseAddon) this, 6060, -5, -7, 0, 0, -1, "(9,6060): -5, -7, 0", 1);// 32
			AddComplexComponent( (BaseAddon) this, 6054, -5, -8, 0, 0, -1, "(10,6054): -5, -8, 0", 1);// 33
			AddComplexComponent( (BaseAddon) this, 6039, -5, -4, 0, 0, -1, "(18,6039): -5, -4, 0", 1);// 34
			AddComplexComponent( (BaseAddon) this, 6039, -5, -3, 0, 0, -1, "(19,6039): -5, -3, 0", 1);// 35
			AddComplexComponent( (BaseAddon) this, 6039, -5, -2, 0, 0, -1, "(23,6039): -5, -2, 0", 1);// 36
			AddComplexComponent( (BaseAddon) this, 6039, -5, -1, 0, 0, -1, "(26,6039): -5, -1, 0", 1);// 37
			AddComplexComponent( (BaseAddon) this, 6039, -6, 0, 0, 0, -1, "(28,6039): -6, 0, 0", 1);// 38
			AddComplexComponent( (BaseAddon) this, 6039, -5, 0, 0, 0, -1, "(35,6039): -5, 0, 0", 1);// 39
			AddComplexComponent( (BaseAddon) this, 6051, -10, 0, 0, 0, -1, "(56,6051): -10, 0, 0", 1);// 40
			AddComplexComponent( (BaseAddon) this, 6039, -7, 0, 0, 0, -1, "(75,6039): -7, 0, 0", 1);// 41
			AddComplexComponent( (BaseAddon) this, 6039, -8, 0, 0, 0, -1, "(82,6039): -8, 0, 0", 1);// 42
			AddComplexComponent( (BaseAddon) this, 6039, -9, 0, 0, 0, -1, "(85,6039): -9, 0, 0", 1);// 43
			AddComplexComponent( (BaseAddon) this, 10298, -8, -1, 0, 0, -1, "Frog Origami", 1);// 44
			AddComplexComponent( (BaseAddon) this, 6051, -9, 2, 0, 0, -1, "(57,6051): -9, 2, 0", 1);// 45
			AddComplexComponent( (BaseAddon) this, 6051, -8, 4, 0, 0, -1, "(58,6051): -8, 4, 0", 1);// 46
			AddComplexComponent( (BaseAddon) this, 6051, -7, 6, 0, 0, -1, "(59,6051): -7, 6, 0", 1);// 47
			AddComplexComponent( (BaseAddon) this, 6056, -7, 7, 0, 0, -1, "(62,6056): -7, 7, 0", 1);// 48
			AddComplexComponent( (BaseAddon) this, 6056, -8, 5, 0, 0, -1, "(63,6056): -8, 5, 0", 1);// 49
			AddComplexComponent( (BaseAddon) this, 6056, -9, 3, 0, 0, -1, "(64,6056): -9, 3, 0", 1);// 50
			AddComplexComponent( (BaseAddon) this, 6059, -7, 5, 0, 0, -1, "(66,6059): -7, 5, 0", 1);// 51
			AddComplexComponent( (BaseAddon) this, 6059, -8, 3, 0, 0, -1, "(67,6059): -8, 3, 0", 1);// 52
			AddComplexComponent( (BaseAddon) this, 6039, -7, 2, 0, 0, -1, "(77,6039): -7, 2, 0", 1);// 53
			AddComplexComponent( (BaseAddon) this, 6039, -7, 3, 0, 0, -1, "(78,6039): -7, 3, 0", 1);// 54
			AddComplexComponent( (BaseAddon) this, 6039, -7, 4, 0, 0, -1, "(79,6039): -7, 4, 0", 1);// 55
			AddComplexComponent( (BaseAddon) this, 6039, -8, 2, 0, 0, -1, "(84,6039): -8, 2, 0", 1);// 56
			AddComplexComponent( (BaseAddon) this, 6039, -6, 2, 0, 0, -1, "(30,6039): -6, 2, 0", 1);// 60
			AddComplexComponent( (BaseAddon) this, 6039, -6, 3, 0, 0, -1, "(31,6039): -6, 3, 0", 1);// 61
			AddComplexComponent( (BaseAddon) this, 6039, -6, 4, 0, 0, -1, "(32,6039): -6, 4, 0", 1);// 62
			AddComplexComponent( (BaseAddon) this, 6039, -6, 5, 0, 0, -1, "(33,6039): -6, 5, 0", 1);// 63
			AddComplexComponent( (BaseAddon) this, 6039, -6, 6, 0, 0, -1, "(34,6039): -6, 6, 0", 1);// 64
			AddComplexComponent( (BaseAddon) this, 6049, -6, 7, 0, 0, -1, "(49,6049): -6, 7, 0", 1);// 65
			AddComplexComponent( (BaseAddon) this, 6039, -5, 2, 0, 0, -1, "(37,6039): -5, 2, 0", 1);// 66
			AddComplexComponent( (BaseAddon) this, 6039, -5, 3, 0, 0, -1, "(38,6039): -5, 3, 0", 1);// 67
			AddComplexComponent( (BaseAddon) this, 6039, -5, 4, 0, 0, -1, "(39,6039): -5, 4, 0", 1);// 68
			AddComplexComponent( (BaseAddon) this, 6039, -5, 5, 0, 0, -1, "(40,6039): -5, 5, 0", 1);// 69
			AddComplexComponent( (BaseAddon) this, 6039, -5, 6, 0, 0, -1, "(41,6039): -5, 6, 0", 1);// 70
			AddComplexComponent( (BaseAddon) this, 6059, -5, 7, 0, 0, -1, "(51,6059): -5, 7, 0", 1);// 71
			AddComplexComponent( (BaseAddon) this, 6056, -5, 8, 0, 0, -1, "(52,6056): -5, 8, 0", 1);// 72
			AddComplexComponent( (BaseAddon) this, 6039, -6, 1, 0, 0, -1, "(29,6039): -6, 1, 0", 1);// 73
			AddComplexComponent( (BaseAddon) this, 6039, -5, 1, 0, 0, -1, "(36,6039): -5, 1, 0", 1);// 74
			AddComplexComponent( (BaseAddon) this, 6056, -10, 1, 0, 0, -1, "(65,6056): -10, 1, 0", 1);// 75
			AddComplexComponent( (BaseAddon) this, 6059, -9, 1, 0, 0, -1, "(68,6059): -9, 1, 0", 1);// 76
			AddComplexComponent( (BaseAddon) this, 6039, -7, 1, 0, 0, -1, "(76,6039): -7, 1, 0", 1);// 77
			AddComplexComponent( (BaseAddon) this, 6039, -8, 1, 0, 0, -1, "(83,6039): -8, 1, 0", 1);// 78
			AddComplexComponent( (BaseAddon) this, 10301, -6, 3, 0, 2253, -1, "Fish Origami", 1);// 82
			AddComplexComponent( (BaseAddon) this, 6039, 0, -6, 0, 0, -1, "(88,6039): 0, -6, 0", 1);// 83
			AddComplexComponent( (BaseAddon) this, 6039, 0, -5, 0, 0, -1, "(89,6039): 0, -5, 0", 1);// 84
			AddComplexComponent( (BaseAddon) this, 6039, 1, -6, 0, 0, -1, "(90,6039): 1, -6, 0", 1);// 85
			AddComplexComponent( (BaseAddon) this, 6039, 1, -5, 0, 0, -1, "(91,6039): 1, -5, 0", 1);// 86
			AddComplexComponent( (BaseAddon) this, 6039, 2, -6, 0, 0, -1, "(92,6039): 2, -6, 0", 1);// 87
			AddComplexComponent( (BaseAddon) this, 6039, 2, -5, 0, 0, -1, "(93,6039): 2, -5, 0", 1);// 88
			AddComplexComponent( (BaseAddon) this, 6039, 3, -6, 0, 0, -1, "(94,6039): 3, -6, 0", 1);// 89
			AddComplexComponent( (BaseAddon) this, 6039, 3, -5, 0, 0, -1, "(95,6039): 3, -5, 0", 1);// 90
			AddComplexComponent( (BaseAddon) this, 6039, 4, -6, 0, 0, -1, "(96,6039): 4, -6, 0", 1);// 91
			AddComplexComponent( (BaseAddon) this, 6039, 4, -5, 0, 0, -1, "(97,6039): 4, -5, 0", 1);// 92
			AddComplexComponent( (BaseAddon) this, 6039, 5, -6, 0, 0, -1, "(98,6039): 5, -6, 0", 1);// 93
			AddComplexComponent( (BaseAddon) this, 6039, 5, -5, 0, 0, -1, "(99,6039): 5, -5, 0", 1);// 94
			AddComplexComponent( (BaseAddon) this, 6039, 6, -6, 0, 0, -1, "(100,6039): 6, -6, 0", 1);// 95
			AddComplexComponent( (BaseAddon) this, 6039, 6, -5, 0, 0, -1, "(101,6039): 6, -5, 0", 1);// 96
			AddComplexComponent( (BaseAddon) this, 6045, 7, -6, 0, 0, -1, "(102,6045): 7, -6, 0", 1);// 97
			AddComplexComponent( (BaseAddon) this, 6057, 7, -5, 0, 0, -1, "(103,6057): 7, -5, 0", 1);// 98
			AddComplexComponent( (BaseAddon) this, 6053, 8, -5, 0, 0, -1, "(104,6053): 8, -5, 0", 1);// 99
			AddComplexComponent( (BaseAddon) this, 6047, 4, -8, 0, 0, -1, "(105,6047): 4, -8, 0", 1);// 100
			AddComplexComponent( (BaseAddon) this, 6047, 6, -7, 0, 0, -1, "(106,6047): 6, -7, 0", 1);// 101
			AddComplexComponent( (BaseAddon) this, 6048, 0, -10, 0, 0, -1, "(107,6048): 0, -10, 0", 1);// 102
			AddComplexComponent( (BaseAddon) this, 6048, 2, -9, 0, 0, -1, "(108,6048): 2, -9, 0", 1);// 103
			AddComplexComponent( (BaseAddon) this, 6057, 1, -9, 0, 0, -1, "(110,6057): 1, -9, 0", 1);// 104
			AddComplexComponent( (BaseAddon) this, 6057, 3, -8, 0, 0, -1, "(111,6057): 3, -8, 0", 1);// 105
			AddComplexComponent( (BaseAddon) this, 6057, 5, -7, 0, 0, -1, "(112,6057): 5, -7, 0", 1);// 106
			AddComplexComponent( (BaseAddon) this, 6053, 1, -10, 0, 0, -1, "(114,6053): 1, -10, 0", 1);// 107
			AddComplexComponent( (BaseAddon) this, 6053, 3, -9, 0, 0, -1, "(115,6053): 3, -9, 0", 1);// 108
			AddComplexComponent( (BaseAddon) this, 6053, 5, -8, 0, 0, -1, "(116,6053): 5, -8, 0", 1);// 109
			AddComplexComponent( (BaseAddon) this, 6039, 0, -7, 0, 0, -1, "(118,6039): 0, -7, 0", 1);// 110
			AddComplexComponent( (BaseAddon) this, 6039, 1, -7, 0, 0, -1, "(119,6039): 1, -7, 0", 1);// 111
			AddComplexComponent( (BaseAddon) this, 6039, 2, -7, 0, 0, -1, "(120,6039): 2, -7, 0", 1);// 112
			AddComplexComponent( (BaseAddon) this, 6039, 3, -7, 0, 0, -1, "(121,6039): 3, -7, 0", 1);// 113
			AddComplexComponent( (BaseAddon) this, 6039, 4, -7, 0, 0, -1, "(122,6039): 4, -7, 0", 1);// 114
			AddComplexComponent( (BaseAddon) this, 6039, 0, -8, 0, 0, -1, "(124,6039): 0, -8, 0", 1);// 115
			AddComplexComponent( (BaseAddon) this, 6039, 1, -8, 0, 0, -1, "(125,6039): 1, -8, 0", 1);// 116
			AddComplexComponent( (BaseAddon) this, 6039, 2, -8, 0, 0, -1, "(126,6039): 2, -8, 0", 1);// 117
			AddComplexComponent( (BaseAddon) this, 6039, 0, -9, 0, 0, -1, "(127,6039): 0, -9, 0", 1);// 118
			AddComplexComponent( (BaseAddon) this, 6053, 7, -7, 0, 0, -1, "(138,6053): 7, -7, 0", 1);// 119
			AddComplexComponent( (BaseAddon) this, 10301, 4, -4, 1, 2789, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 6039, -1, -6, 0, 0, -1, "(86,6039): -1, -6, 0", 1);// 129
			AddComplexComponent( (BaseAddon) this, 6039, -1, -5, 0, 0, -1, "(87,6039): -1, -5, 0", 1);// 130
			AddComplexComponent( (BaseAddon) this, 6060, -1, -9, 0, 0, -1, "(109,6060): -1, -9, 0", 1);// 131
			AddComplexComponent( (BaseAddon) this, 6054, -1, -10, 0, 0, -1, "(113,6054): -1, -10, 0", 1);// 132
			AddComplexComponent( (BaseAddon) this, 6039, -1, -7, 0, 0, -1, "(117,6039): -1, -7, 0", 1);// 133
			AddComplexComponent( (BaseAddon) this, 6039, -1, -8, 0, 0, -1, "(123,6039): -1, -8, 0", 1);// 134
			AddComplexComponent( (BaseAddon) this, 6048, -2, -9, 0, 0, -1, "(128,6048): -2, -9, 0", 1);// 135
			AddComplexComponent( (BaseAddon) this, 6039, -2, -8, 0, 0, -1, "(129,6039): -2, -8, 0", 1);// 136
			AddComplexComponent( (BaseAddon) this, 6039, -2, -7, 0, 0, -1, "(130,6039): -2, -7, 0", 1);// 137
			AddComplexComponent( (BaseAddon) this, 6039, -2, -6, 0, 0, -1, "(131,6039): -2, -6, 0", 1);// 138
			AddComplexComponent( (BaseAddon) this, 6039, -2, -5, 0, 0, -1, "(132,6039): -2, -5, 0", 1);// 139
			AddComplexComponent( (BaseAddon) this, 6039, -1, -4, 0, 0, -1, "(139,6039): -1, -4, 0", 1);// 140
			AddComplexComponent( (BaseAddon) this, 6039, 0, -4, 0, 0, -1, "(142,6039): 0, -4, 0", 1);// 141
			AddComplexComponent( (BaseAddon) this, 6039, 1, -4, 0, 0, -1, "(148,6039): 1, -4, 0", 1);// 142
			AddComplexComponent( (BaseAddon) this, 6039, 2, -4, 0, 0, -1, "(152,6039): 2, -4, 0", 1);// 143
			AddComplexComponent( (BaseAddon) this, 6039, 3, -4, 0, 0, -1, "(156,6039): 3, -4, 0", 1);// 144
			AddComplexComponent( (BaseAddon) this, 6039, 4, -4, 0, 0, -1, "(160,6039): 4, -4, 0", 1);// 145
			AddComplexComponent( (BaseAddon) this, 6039, 5, -4, 0, 0, -1, "(164,6039): 5, -4, 0", 1);// 146
			AddComplexComponent( (BaseAddon) this, 6039, 6, -4, 0, 0, -1, "(168,6039): 6, -4, 0", 1);// 147
			AddComplexComponent( (BaseAddon) this, 6045, 8, -4, 0, 0, -1, "(172,6045): 8, -4, 0", 1);// 148
			AddComplexComponent( (BaseAddon) this, 6039, 7, -4, 0, 0, -1, "(188,6039): 7, -4, 0", 1);// 149
			AddComplexComponent( (BaseAddon) this, 6039, -2, -4, 0, 0, -1, "(196,6039): -2, -4, 0", 1);// 150
			AddComplexComponent( (BaseAddon) this, 6039, -1, -3, 0, 0, -1, "(140,6039): -1, -3, 0", 1);// 151
			AddComplexComponent( (BaseAddon) this, 6039, 0, -3, 0, 0, -1, "(143,6039): 0, -3, 0", 1);// 152
			AddComplexComponent( (BaseAddon) this, 6039, 1, -3, 0, 0, -1, "(149,6039): 1, -3, 0", 1);// 153
			AddComplexComponent( (BaseAddon) this, 6039, 2, -3, 0, 0, -1, "(153,6039): 2, -3, 0", 1);// 154
			AddComplexComponent( (BaseAddon) this, 6039, 3, -3, 0, 0, -1, "(157,6039): 3, -3, 0", 1);// 155
			AddComplexComponent( (BaseAddon) this, 6039, 4, -3, 0, 0, -1, "(161,6039): 4, -3, 0", 1);// 156
			AddComplexComponent( (BaseAddon) this, 6039, 5, -3, 0, 0, -1, "(165,6039): 5, -3, 0", 1);// 157
			AddComplexComponent( (BaseAddon) this, 6039, 6, -3, 0, 0, -1, "(169,6039): 6, -3, 0", 1);// 158
			AddComplexComponent( (BaseAddon) this, 6057, 8, -3, 0, 0, -1, "(179,6057): 8, -3, 0", 1);// 159
			AddComplexComponent( (BaseAddon) this, 6053, 9, -3, 0, 0, -1, "(187,6053): 9, -3, 0", 1);// 160
			AddComplexComponent( (BaseAddon) this, 6039, 7, -3, 0, 0, -1, "(189,6039): 7, -3, 0", 1);// 161
			AddComplexComponent( (BaseAddon) this, 6039, -2, -3, 0, 0, -1, "(197,6039): -2, -3, 0", 1);// 162
			AddComplexComponent( (BaseAddon) this, 6039, -2, -2, 0, 0, -1, "(141,6039): -2, -2, 0", 1);// 163
			AddComplexComponent( (BaseAddon) this, 6039, -1, -2, 0, 0, -1, "(144,6039): -1, -2, 0", 1);// 164
			AddComplexComponent( (BaseAddon) this, 6039, 0, -2, 0, 0, -1, "(146,6039): 0, -2, 0", 1);// 165
			AddComplexComponent( (BaseAddon) this, 6039, 1, -2, 0, 0, -1, "(150,6039): 1, -2, 0", 1);// 166
			AddComplexComponent( (BaseAddon) this, 6039, 2, -2, 0, 0, -1, "(154,6039): 2, -2, 0", 1);// 167
			AddComplexComponent( (BaseAddon) this, 6039, 3, -2, 0, 0, -1, "(158,6039): 3, -2, 0", 1);// 168
			AddComplexComponent( (BaseAddon) this, 6039, 4, -2, 0, 0, -1, "(162,6039): 4, -2, 0", 1);// 169
			AddComplexComponent( (BaseAddon) this, 6039, 5, -2, 0, 0, -1, "(166,6039): 5, -2, 0", 1);// 170
			AddComplexComponent( (BaseAddon) this, 6039, 6, -2, 0, 0, -1, "(170,6039): 6, -2, 0", 1);// 171
			AddComplexComponent( (BaseAddon) this, 6045, 9, -2, 0, 0, -1, "(173,6045): 9, -2, 0", 1);// 172
			AddComplexComponent( (BaseAddon) this, 6039, 7, -2, 0, 0, -1, "(190,6039): 7, -2, 0", 1);// 173
			AddComplexComponent( (BaseAddon) this, 6039, 8, -2, 0, 0, -1, "(192,6039): 8, -2, 0", 1);// 174
			AddComplexComponent( (BaseAddon) this, 6039, -1, -1, 0, 0, -1, "(145,6039): -1, -1, 0", 1);// 175
			AddComplexComponent( (BaseAddon) this, 6039, 0, -1, 0, 0, -1, "(147,6039): 0, -1, 0", 1);// 176
			AddComplexComponent( (BaseAddon) this, 6039, 1, -1, 0, 0, -1, "(151,6039): 1, -1, 0", 1);// 177
			AddComplexComponent( (BaseAddon) this, 6039, 2, -1, 0, 0, -1, "(155,6039): 2, -1, 0", 1);// 178
			AddComplexComponent( (BaseAddon) this, 6039, 3, -1, 0, 0, -1, "(159,6039): 3, -1, 0", 1);// 179
			AddComplexComponent( (BaseAddon) this, 6039, 4, -1, 0, 0, -1, "(163,6039): 4, -1, 0", 1);// 180
			AddComplexComponent( (BaseAddon) this, 6039, 5, -1, 0, 0, -1, "(167,6039): 5, -1, 0", 1);// 181
			AddComplexComponent( (BaseAddon) this, 6039, 6, -1, 0, 0, -1, "(171,6039): 6, -1, 0", 1);// 182
			AddComplexComponent( (BaseAddon) this, 6057, 9, -1, 0, 0, -1, "(178,6057): 9, -1, 0", 1);// 183
			AddComplexComponent( (BaseAddon) this, 6039, 7, -1, 0, 0, -1, "(191,6039): 7, -1, 0", 1);// 184
			AddComplexComponent( (BaseAddon) this, 6039, 8, -1, 0, 0, -1, "(193,6039): 8, -1, 0", 1);// 185
			AddComplexComponent( (BaseAddon) this, 6039, -2, -1, 0, 0, -1, "(202,6039): -2, -1, 0", 1);// 186
			AddComplexComponent( (BaseAddon) this, 6053, 10, -1, 0, 0, -1, "(186,6053): 10, -1, 0", 1);// 188
			AddComplexComponent( (BaseAddon) this, 6054, -3, -9, 0, 0, -1, "(133,6054): -3, -9, 0", 1);// 189
			AddComplexComponent( (BaseAddon) this, 6060, -3, -8, 0, 0, -1, "(134,6060): -3, -8, 0", 1);// 190
			AddComplexComponent( (BaseAddon) this, 6039, -3, -7, 0, 0, -1, "(135,6039): -3, -7, 0", 1);// 191
			AddComplexComponent( (BaseAddon) this, 6039, -3, -6, 0, 0, -1, "(136,6039): -3, -6, 0", 1);// 192
			AddComplexComponent( (BaseAddon) this, 6039, -3, -5, 0, 0, -1, "(137,6039): -3, -5, 0", 1);// 193
			AddComplexComponent( (BaseAddon) this, 6039, -3, -4, 0, 0, -1, "(198,6039): -3, -4, 0", 1);// 194
			AddComplexComponent( (BaseAddon) this, 6039, -3, -3, 0, 0, -1, "(199,6039): -3, -3, 0", 1);// 195
			AddComplexComponent( (BaseAddon) this, 6039, -3, -2, 0, 0, -1, "(200,6039): -3, -2, 0", 1);// 196
			AddComplexComponent( (BaseAddon) this, 6039, -3, -1, 0, 0, -1, "(201,6039): -3, -1, 0", 1);// 197
			AddComplexComponent( (BaseAddon) this, 6039, -4, -6, 0, 0, -1, "(5,6039): -4, -6, 0", 1);// 198
			AddComplexComponent( (BaseAddon) this, 6039, -4, -5, 0, 0, -1, "(6,6039): -4, -5, 0", 1);// 199
			AddComplexComponent( (BaseAddon) this, 6047, -4, -8, 0, 0, -1, "(8,6047): -4, -8, 0", 1);// 200
			AddComplexComponent( (BaseAddon) this, 6039, -4, -7, 0, 0, -1, "(11,6039): -4, -7, 0", 1);// 201
			AddComplexComponent( (BaseAddon) this, 6039, -4, -4, 0, 0, -1, "(21,6039): -4, -4, 0", 1);// 202
			AddComplexComponent( (BaseAddon) this, 6039, -4, -3, 0, 0, -1, "(22,6039): -4, -3, 0", 1);// 203
			AddComplexComponent( (BaseAddon) this, 6039, -4, -2, 0, 0, -1, "(24,6039): -4, -2, 0", 1);// 204
			AddComplexComponent( (BaseAddon) this, 6039, -4, -1, 0, 0, -1, "(27,6039): -4, -1, 0", 1);// 205
			AddComplexComponent( (BaseAddon) this, 6039, -4, 0, 0, 0, -1, "(42,6039): -4, 0, 0", 1);// 206
			AddComplexComponent( (BaseAddon) this, 6046, 10, 0, 0, 0, -1, "(177,6046): 10, 0, 0", 1);// 207
			AddComplexComponent( (BaseAddon) this, 6039, 8, 0, 0, 0, -1, "(194,6039): 8, 0, 0", 1);// 208
			AddComplexComponent( (BaseAddon) this, 6039, 9, 0, 0, 0, -1, "(195,6039): 9, 0, 0", 1);// 209
			AddComplexComponent( (BaseAddon) this, 6039, -3, 0, 0, 0, -1, "(203,6039): -3, 0, 0", 1);// 210
			AddComplexComponent( (BaseAddon) this, 6039, -2, 0, 0, 0, -1, "(210,6039): -2, 0, 0", 1);// 211
			AddComplexComponent( (BaseAddon) this, 6039, -1, 0, 0, 0, -1, "(217,6039): -1, 0, 0", 1);// 212
			AddComplexComponent( (BaseAddon) this, 6039, 0, 0, 0, 0, -1, "(224,6039): 0, 0, 0", 1);// 213
			AddComplexComponent( (BaseAddon) this, 6039, 1, 0, 0, 0, -1, "(231,6039): 1, 0, 0", 1);// 214
			AddComplexComponent( (BaseAddon) this, 6039, 2, 0, 0, 0, -1, "(238,6039): 2, 0, 0", 1);// 215
			AddComplexComponent( (BaseAddon) this, 6039, 3, 0, 0, 0, -1, "(245,6039): 3, 0, 0", 1);// 216
			AddComplexComponent( (BaseAddon) this, 6039, 4, 0, 0, 0, -1, "(252,6039): 4, 0, 0", 1);// 217
			AddComplexComponent( (BaseAddon) this, 6039, 5, 0, 0, 0, -1, "(259,6039): 5, 0, 0", 1);// 218
			AddComplexComponent( (BaseAddon) this, 6039, 6, 0, 0, 0, -1, "(266,6039): 6, 0, 0", 1);// 219
			AddComplexComponent( (BaseAddon) this, 6039, 7, 0, 0, 0, -1, "(273,6039): 7, 0, 0", 1);// 220
			AddComplexComponent( (BaseAddon) this, 10301, -1, -4, 0, 1174, -1, "Fish Origami", 1);// 226
			AddComplexComponent( (BaseAddon) this, 10301, 2, -2, 0, 1278, -1, "Fish Origami", 1);// 228
			AddComplexComponent( (BaseAddon) this, 6045, 8, 4, 0, 0, -1, "(174,6045): 8, 4, 0", 1);// 229
			AddComplexComponent( (BaseAddon) this, 6045, 7, 6, 0, 0, -1, "(175,6045): 7, 6, 0", 1);// 230
			AddComplexComponent( (BaseAddon) this, 6046, 9, 2, 0, 0, -1, "(176,6046): 9, 2, 0", 1);// 231
			AddComplexComponent( (BaseAddon) this, 6058, 8, 3, 0, 0, -1, "(181,6058): 8, 3, 0", 1);// 232
			AddComplexComponent( (BaseAddon) this, 6058, 7, 5, 0, 0, -1, "(182,6058): 7, 5, 0", 1);// 233
			AddComplexComponent( (BaseAddon) this, 6055, 8, 5, 0, 0, -1, "(183,6055): 8, 5, 0", 1);// 234
			AddComplexComponent( (BaseAddon) this, 6055, 9, 3, 0, 0, -1, "(184,6055): 9, 3, 0", 1);// 235
			AddComplexComponent( (BaseAddon) this, 6039, 0, 2, 0, 0, -1, "(226,6039): 0, 2, 0", 1);// 236
			AddComplexComponent( (BaseAddon) this, 6039, 0, 3, 0, 0, -1, "(227,6039): 0, 3, 0", 1);// 237
			AddComplexComponent( (BaseAddon) this, 6039, 0, 4, 0, 0, -1, "(228,6039): 0, 4, 0", 1);// 238
			AddComplexComponent( (BaseAddon) this, 6039, 0, 5, 0, 0, -1, "(229,6039): 0, 5, 0", 1);// 239
			AddComplexComponent( (BaseAddon) this, 6039, 0, 6, 0, 0, -1, "(230,6039): 0, 6, 0", 1);// 240
			AddComplexComponent( (BaseAddon) this, 6039, 1, 2, 0, 0, -1, "(233,6039): 1, 2, 0", 1);// 241
			AddComplexComponent( (BaseAddon) this, 6039, 1, 3, 0, 0, -1, "(234,6039): 1, 3, 0", 1);// 242
			AddComplexComponent( (BaseAddon) this, 6039, 1, 4, 0, 0, -1, "(235,6039): 1, 4, 0", 1);// 243
			AddComplexComponent( (BaseAddon) this, 6039, 1, 5, 0, 0, -1, "(236,6039): 1, 5, 0", 1);// 244
			AddComplexComponent( (BaseAddon) this, 6039, 1, 6, 0, 0, -1, "(237,6039): 1, 6, 0", 1);// 245
			AddComplexComponent( (BaseAddon) this, 6039, 2, 2, 0, 0, -1, "(240,6039): 2, 2, 0", 1);// 246
			AddComplexComponent( (BaseAddon) this, 6039, 2, 3, 0, 0, -1, "(241,6039): 2, 3, 0", 1);// 247
			AddComplexComponent( (BaseAddon) this, 6039, 2, 4, 0, 0, -1, "(242,6039): 2, 4, 0", 1);// 248
			AddComplexComponent( (BaseAddon) this, 6039, 2, 5, 0, 0, -1, "(243,6039): 2, 5, 0", 1);// 249
			AddComplexComponent( (BaseAddon) this, 6039, 2, 6, 0, 0, -1, "(244,6039): 2, 6, 0", 1);// 250
			AddComplexComponent( (BaseAddon) this, 6039, 3, 2, 0, 0, -1, "(247,6039): 3, 2, 0", 1);// 251
			AddComplexComponent( (BaseAddon) this, 6039, 3, 3, 0, 0, -1, "(248,6039): 3, 3, 0", 1);// 252
			AddComplexComponent( (BaseAddon) this, 6039, 3, 4, 0, 0, -1, "(249,6039): 3, 4, 0", 1);// 253
			AddComplexComponent( (BaseAddon) this, 6039, 3, 5, 0, 0, -1, "(250,6039): 3, 5, 0", 1);// 254
			AddComplexComponent( (BaseAddon) this, 6039, 3, 6, 0, 0, -1, "(251,6039): 3, 6, 0", 1);// 255
			AddComplexComponent( (BaseAddon) this, 6039, 4, 2, 0, 0, -1, "(254,6039): 4, 2, 0", 1);// 256
			AddComplexComponent( (BaseAddon) this, 6039, 4, 3, 0, 0, -1, "(255,6039): 4, 3, 0", 1);// 257
			AddComplexComponent( (BaseAddon) this, 6039, 4, 4, 0, 0, -1, "(256,6039): 4, 4, 0", 1);// 258
			AddComplexComponent( (BaseAddon) this, 6039, 4, 5, 0, 0, -1, "(257,6039): 4, 5, 0", 1);// 259
			AddComplexComponent( (BaseAddon) this, 6039, 4, 6, 0, 0, -1, "(258,6039): 4, 6, 0", 1);// 260
			AddComplexComponent( (BaseAddon) this, 6039, 5, 2, 0, 0, -1, "(261,6039): 5, 2, 0", 1);// 261
			AddComplexComponent( (BaseAddon) this, 6039, 5, 3, 0, 0, -1, "(262,6039): 5, 3, 0", 1);// 262
			AddComplexComponent( (BaseAddon) this, 6039, 5, 4, 0, 0, -1, "(263,6039): 5, 4, 0", 1);// 263
			AddComplexComponent( (BaseAddon) this, 6039, 5, 5, 0, 0, -1, "(264,6039): 5, 5, 0", 1);// 264
			AddComplexComponent( (BaseAddon) this, 6039, 5, 6, 0, 0, -1, "(265,6039): 5, 6, 0", 1);// 265
			AddComplexComponent( (BaseAddon) this, 6039, 6, 2, 0, 0, -1, "(268,6039): 6, 2, 0", 1);// 266
			AddComplexComponent( (BaseAddon) this, 6039, 6, 3, 0, 0, -1, "(269,6039): 6, 3, 0", 1);// 267
			AddComplexComponent( (BaseAddon) this, 6039, 6, 4, 0, 0, -1, "(270,6039): 6, 4, 0", 1);// 268
			AddComplexComponent( (BaseAddon) this, 6039, 6, 5, 0, 0, -1, "(271,6039): 6, 5, 0", 1);// 269
			AddComplexComponent( (BaseAddon) this, 6039, 6, 6, 0, 0, -1, "(272,6039): 6, 6, 0", 1);// 270
			AddComplexComponent( (BaseAddon) this, 6039, 7, 2, 0, 0, -1, "(275,6039): 7, 2, 0", 1);// 271
			AddComplexComponent( (BaseAddon) this, 6039, 7, 3, 0, 0, -1, "(276,6039): 7, 3, 0", 1);// 272
			AddComplexComponent( (BaseAddon) this, 6039, 7, 4, 0, 0, -1, "(277,6039): 7, 4, 0", 1);// 273
			AddComplexComponent( (BaseAddon) this, 6039, 8, 2, 0, 0, -1, "(279,6039): 8, 2, 0", 1);// 274
			AddComplexComponent( (BaseAddon) this, 6049, 2, 9, 0, 0, -1, "(281,6049): 2, 9, 0", 1);// 275
			AddComplexComponent( (BaseAddon) this, 6049, 4, 8, 0, 0, -1, "(282,6049): 4, 8, 0", 1);// 276
			AddComplexComponent( (BaseAddon) this, 6049, 6, 7, 0, 0, -1, "(283,6049): 6, 7, 0", 1);// 277
			AddComplexComponent( (BaseAddon) this, 6058, 5, 7, 0, 0, -1, "(284,6058): 5, 7, 0", 1);// 278
			AddComplexComponent( (BaseAddon) this, 6049, 0, 10, 0, 0, -1, "(285,6049): 0, 10, 0", 1);// 279
			AddComplexComponent( (BaseAddon) this, 6058, 3, 8, 0, 0, -1, "(286,6058): 3, 8, 0", 1);// 280
			AddComplexComponent( (BaseAddon) this, 6058, 1, 9, 0, 0, -1, "(287,6058): 1, 9, 0", 1);// 281
			AddComplexComponent( (BaseAddon) this, 6055, 5, 8, 0, 0, -1, "(292,6055): 5, 8, 0", 1);// 282
			AddComplexComponent( (BaseAddon) this, 6055, 3, 9, 0, 0, -1, "(293,6055): 3, 9, 0", 1);// 283
			AddComplexComponent( (BaseAddon) this, 6055, 1, 10, 0, 0, -1, "(294,6055): 1, 10, 0", 1);// 284
			AddComplexComponent( (BaseAddon) this, 6039, 0, 7, 0, 0, -1, "(298,6039): 0, 7, 0", 1);// 285
			AddComplexComponent( (BaseAddon) this, 6039, 1, 7, 0, 0, -1, "(299,6039): 1, 7, 0", 1);// 286
			AddComplexComponent( (BaseAddon) this, 6039, 2, 7, 0, 0, -1, "(300,6039): 2, 7, 0", 1);// 287
			AddComplexComponent( (BaseAddon) this, 6039, 3, 7, 0, 0, -1, "(301,6039): 3, 7, 0", 1);// 288
			AddComplexComponent( (BaseAddon) this, 6039, 4, 7, 0, 0, -1, "(302,6039): 4, 7, 0", 1);// 289
			AddComplexComponent( (BaseAddon) this, 6039, 0, 8, 0, 0, -1, "(305,6039): 0, 8, 0", 1);// 290
			AddComplexComponent( (BaseAddon) this, 6039, 1, 8, 0, 0, -1, "(306,6039): 1, 8, 0", 1);// 291
			AddComplexComponent( (BaseAddon) this, 6039, 2, 8, 0, 0, -1, "(307,6039): 2, 8, 0", 1);// 292
			AddComplexComponent( (BaseAddon) this, 6039, 0, 9, 0, 0, -1, "(308,6039): 0, 9, 0", 1);// 293
			AddComplexComponent( (BaseAddon) this, 6055, 7, 7, 0, 0, -1, "(309,6055): 7, 7, 0", 1);// 294
			AddComplexComponent( (BaseAddon) this, 10301, 6, 4, 1, 2260, -1, "", 1);// 295
			AddComplexComponent( (BaseAddon) this, 10301, -2, 4, 1, 2253, -1, "", 1);// 296
			AddComplexComponent( (BaseAddon) this, 6039, -1, 2, 0, 0, -1, "(219,6039): -1, 2, 0", 1);// 304
			AddComplexComponent( (BaseAddon) this, 6039, -1, 3, 0, 0, -1, "(220,6039): -1, 3, 0", 1);// 305
			AddComplexComponent( (BaseAddon) this, 6039, -1, 4, 0, 0, -1, "(221,6039): -1, 4, 0", 1);// 306
			AddComplexComponent( (BaseAddon) this, 6039, -1, 5, 0, 0, -1, "(222,6039): -1, 5, 0", 1);// 307
			AddComplexComponent( (BaseAddon) this, 6039, -1, 6, 0, 0, -1, "(223,6039): -1, 6, 0", 1);// 308
			AddComplexComponent( (BaseAddon) this, 6059, -1, 9, 0, 0, -1, "(288,6059): -1, 9, 0", 1);// 309
			AddComplexComponent( (BaseAddon) this, 6056, -1, 10, 0, 0, -1, "(291,6056): -1, 10, 0", 1);// 310
			AddComplexComponent( (BaseAddon) this, 6039, -1, 7, 0, 0, -1, "(297,6039): -1, 7, 0", 1);// 311
			AddComplexComponent( (BaseAddon) this, 6039, -1, 8, 0, 0, -1, "(304,6039): -1, 8, 0", 1);// 312
			AddComplexComponent( (BaseAddon) this, 6039, -2, 2, 0, 0, -1, "(212,6039): -2, 2, 0", 1);// 313
			AddComplexComponent( (BaseAddon) this, 6039, -2, 3, 0, 0, -1, "(213,6039): -2, 3, 0", 1);// 314
			AddComplexComponent( (BaseAddon) this, 6039, -2, 4, 0, 0, -1, "(214,6039): -2, 4, 0", 1);// 315
			AddComplexComponent( (BaseAddon) this, 6039, -2, 5, 0, 0, -1, "(215,6039): -2, 5, 0", 1);// 316
			AddComplexComponent( (BaseAddon) this, 6039, -2, 6, 0, 0, -1, "(216,6039): -2, 6, 0", 1);// 317
			AddComplexComponent( (BaseAddon) this, 6049, -2, 9, 0, 0, -1, "(280,6049): -2, 9, 0", 1);// 318
			AddComplexComponent( (BaseAddon) this, 6039, -2, 7, 0, 0, -1, "(296,6039): -2, 7, 0", 1);// 319
			AddComplexComponent( (BaseAddon) this, 6039, -2, 8, 0, 0, -1, "(303,6039): -2, 8, 0", 1);// 320
			AddComplexComponent( (BaseAddon) this, 6039, -3, 2, 0, 0, -1, "(205,6039): -3, 2, 0", 1);// 321
			AddComplexComponent( (BaseAddon) this, 6039, -3, 3, 0, 0, -1, "(206,6039): -3, 3, 0", 1);// 322
			AddComplexComponent( (BaseAddon) this, 6039, -3, 4, 0, 0, -1, "(207,6039): -3, 4, 0", 1);// 323
			AddComplexComponent( (BaseAddon) this, 6039, -3, 5, 0, 0, -1, "(208,6039): -3, 5, 0", 1);// 324
			AddComplexComponent( (BaseAddon) this, 6039, -3, 6, 0, 0, -1, "(209,6039): -3, 6, 0", 1);// 325
			AddComplexComponent( (BaseAddon) this, 6059, -3, 8, 0, 0, -1, "(289,6059): -3, 8, 0", 1);// 326
			AddComplexComponent( (BaseAddon) this, 6056, -3, 9, 0, 0, -1, "(290,6056): -3, 9, 0", 1);// 327
			AddComplexComponent( (BaseAddon) this, 6039, -3, 7, 0, 0, -1, "(295,6039): -3, 7, 0", 1);// 328
			AddComplexComponent( (BaseAddon) this, 6058, 9, 1, 0, 0, -1, "(180,6058): 9, 1, 0", 1);// 329
			AddComplexComponent( (BaseAddon) this, 6055, 10, 1, 0, 0, -1, "(185,6055): 10, 1, 0", 1);// 330
			AddComplexComponent( (BaseAddon) this, 6039, -3, 1, 0, 0, -1, "(204,6039): -3, 1, 0", 1);// 331
			AddComplexComponent( (BaseAddon) this, 6039, -2, 1, 0, 0, -1, "(211,6039): -2, 1, 0", 1);// 332
			AddComplexComponent( (BaseAddon) this, 6039, -1, 1, 0, 0, -1, "(218,6039): -1, 1, 0", 1);// 333
			AddComplexComponent( (BaseAddon) this, 6039, 0, 1, 0, 0, -1, "(225,6039): 0, 1, 0", 1);// 334
			AddComplexComponent( (BaseAddon) this, 6039, 1, 1, 0, 0, -1, "(232,6039): 1, 1, 0", 1);// 335
			AddComplexComponent( (BaseAddon) this, 6039, 2, 1, 0, 0, -1, "(239,6039): 2, 1, 0", 1);// 336
			AddComplexComponent( (BaseAddon) this, 6039, 3, 1, 0, 0, -1, "(246,6039): 3, 1, 0", 1);// 337
			AddComplexComponent( (BaseAddon) this, 6039, 4, 1, 0, 0, -1, "(253,6039): 4, 1, 0", 1);// 338
			AddComplexComponent( (BaseAddon) this, 6039, 5, 1, 0, 0, -1, "(260,6039): 5, 1, 0", 1);// 339
			AddComplexComponent( (BaseAddon) this, 6039, 6, 1, 0, 0, -1, "(267,6039): 6, 1, 0", 1);// 340
			AddComplexComponent( (BaseAddon) this, 6039, 7, 1, 0, 0, -1, "(274,6039): 7, 1, 0", 1);// 341
			AddComplexComponent( (BaseAddon) this, 6039, 8, 1, 0, 0, -1, "(278,6039): 8, 1, 0", 1);// 342
			AddComplexComponent( (BaseAddon) this, 6039, -4, 1, 0, 0, -1, "(43,6039): -4, 1, 0", 1);// 343
			AddComplexComponent( (BaseAddon) this, 6039, -4, 2, 0, 0, -1, "(44,6039): -4, 2, 0", 1);// 344
			AddComplexComponent( (BaseAddon) this, 6039, -4, 3, 0, 0, -1, "(45,6039): -4, 3, 0", 1);// 345
			AddComplexComponent( (BaseAddon) this, 6039, -4, 4, 0, 0, -1, "(46,6039): -4, 4, 0", 1);// 346
			AddComplexComponent( (BaseAddon) this, 6039, -4, 5, 0, 0, -1, "(47,6039): -4, 5, 0", 1);// 347
			AddComplexComponent( (BaseAddon) this, 6039, -4, 6, 0, 0, -1, "(48,6039): -4, 6, 0", 1);// 348
			AddComplexComponent( (BaseAddon) this, 6049, -4, 8, 0, 0, -1, "(50,6049): -4, 8, 0", 1);// 349
			AddComplexComponent( (BaseAddon) this, 6039, -4, 7, 0, 0, -1, "(53,6039): -4, 7, 0", 1);// 350
			AddComplexComponent( (BaseAddon) this, 10301, 1, 2, 0, 1177, -1, "Fish Origami", 1);// 358
			AddComplexComponent( (BaseAddon) this, 10301, 3, 2, 0, 1283, -1, "Fish Origami", 1);// 359

		}

		public kidtownpondAddon( Serial serial ) : base( serial )
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

	public class kidtownpondAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new kidtownpondAddon();
			}
		}

		[Constructable]
		public kidtownpondAddonDeed()
		{
			Name = "kidtownpond";
		}

		public kidtownpondAddonDeed( Serial serial ) : base( serial )
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