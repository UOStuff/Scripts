
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
	public class EasterHouseAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2814, 0, -3, 1}, {2813, 1, -3, 1}, {2815, -1, -3, 1}// 158	159	160	
			, {2814, 0, -3, 4}, {2813, 1, -3, 4}, {2815, -1, -3, 4}// 164	165	166	
			, {2485, 4, 0, 8}, {2484, 4, 1, 17}// 288	289	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EasterHouseAddonDeed();
			}
		}

		[ Constructable ]
		public EasterHouseAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1173, -3, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1173, -3, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1173, -3, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1173, -3, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1173, -3, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1173, -3, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1173, -3, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1173, -2, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1173, -1, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1173, 0, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1173, 1, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1173, 2, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1173, -2, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1173, -1, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1173, 0, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1173, 1, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1173, 2, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1173, -2, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1173, -1, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1173, 0, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1173, 1, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1173, 2, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1173, -2, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1173, -1, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1173, 0, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1173, 1, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1173, 2, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1173, -2, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1173, -2, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1173, -1, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1173, -1, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1173, -2, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1173, -1, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1173, 0, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1173, 1, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1173, 2, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1173, 0, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1173, 1, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1173, 2, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1173, 0, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1173, 1, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1173, 2, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1173, 2, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1173, 1, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1173, 0, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1173, -1, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1173, -2, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1173, -3, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1173, -4, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1173, -4, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1173, -4, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1173, -4, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1173, -4, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1173, -4, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 54
			AddComplexComponent( (BaseAddon) this, 1173, -4, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 55
			AddComplexComponent( (BaseAddon) this, 1173, -4, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 56
			AddComplexComponent( (BaseAddon) this, 9488, -3, 4, 1, 2891, -1, "strawberry cream wall", 1);// 57
			AddComplexComponent( (BaseAddon) this, 9488, -2, 4, 1, 2891, -1, "strawberry cream wall", 1);// 58
			AddComplexComponent( (BaseAddon) this, 249, 2, -4, 1, 2891, -1, "strawberry cream wall", 1);// 59
			AddComplexComponent( (BaseAddon) this, 249, 1, -4, 1, 2891, -1, "strawberry cream wall", 1);// 60
			AddComplexComponent( (BaseAddon) this, 249, 0, -4, 1, 2891, -1, "strawberry cream wall", 1);// 61
			AddComplexComponent( (BaseAddon) this, 249, -1, -4, 1, 2891, -1, "strawberry cream wall", 1);// 62
			AddComplexComponent( (BaseAddon) this, 249, -2, -4, 1, 2891, -1, "strawberry cream wall", 1);// 63
			AddComplexComponent( (BaseAddon) this, 249, -3, -4, 1, 2891, -1, "strawberry cream wall", 1);// 64
			AddComplexComponent( (BaseAddon) this, 249, -4, -4, 1, 2891, -1, "strawberry cream wall", 1);// 65
			AddComplexComponent( (BaseAddon) this, 249, -4, 4, 1, 2891, -1, "strawberry cream wall", 1);// 66
			AddComplexComponent( (BaseAddon) this, 249, -1, 4, 1, 2891, -1, "strawberry cream wall", 1);// 67
			AddComplexComponent( (BaseAddon) this, 249, 2, 4, 1, 2891, -1, "strawberry cream wall", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1341, -4, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1341, -4, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1341, -4, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1341, -4, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1341, 2, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1341, 0, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1341, -3, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1341, -1, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 76
			AddComplexComponent( (BaseAddon) this, 1341, -2, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 77
			AddComplexComponent( (BaseAddon) this, 1341, -3, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 78
			AddComplexComponent( (BaseAddon) this, 1341, -3, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 79
			AddComplexComponent( (BaseAddon) this, 1341, -3, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1341, -2, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1341, -2, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1341, -2, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 83
			AddComplexComponent( (BaseAddon) this, 1341, -1, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1341, -1, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 85
			AddComplexComponent( (BaseAddon) this, 1341, -1, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 86
			AddComplexComponent( (BaseAddon) this, 1341, 0, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 87
			AddComplexComponent( (BaseAddon) this, 1341, 0, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 88
			AddComplexComponent( (BaseAddon) this, 1341, 1, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 89
			AddComplexComponent( (BaseAddon) this, 1341, 2, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 90
			AddComplexComponent( (BaseAddon) this, 1341, 1, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 91
			AddComplexComponent( (BaseAddon) this, 1341, 2, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 92
			AddComplexComponent( (BaseAddon) this, 1341, 2, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 93
			AddComplexComponent( (BaseAddon) this, 250, -5, -3, 1, 2891, -1, "strawberry cream wall", 1);// 94
			AddComplexComponent( (BaseAddon) this, 250, -5, -2, 1, 2891, -1, "strawberry cream wall", 1);// 95
			AddComplexComponent( (BaseAddon) this, 250, -5, 0, 1, 2891, -1, "strawberry cream wall", 1);// 96
			AddComplexComponent( (BaseAddon) this, 250, -5, -1, 1, 2891, -1, "strawberry cream wall", 1);// 97
			AddComplexComponent( (BaseAddon) this, 250, -5, 1, 1, 2891, -1, "strawberry cream wall", 1);// 98
			AddComplexComponent( (BaseAddon) this, 250, -5, 2, 1, 2891, -1, "strawberry cream wall", 1);// 99
			AddComplexComponent( (BaseAddon) this, 250, -5, 3, 1, 2891, -1, "strawberry cream wall", 1);// 100
			AddComplexComponent( (BaseAddon) this, 250, -5, 4, 1, 2891, -1, "strawberry cream wall", 1);// 101
			AddComplexComponent( (BaseAddon) this, 1341, 0, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 102
			AddComplexComponent( (BaseAddon) this, 1341, 1, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 103
			AddComplexComponent( (BaseAddon) this, 1341, 1, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 104
			AddComplexComponent( (BaseAddon) this, 1341, -4, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 105
			AddComplexComponent( (BaseAddon) this, 1341, -4, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 106
			AddComplexComponent( (BaseAddon) this, 1341, -4, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1341, -4, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1341, -3, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 109
			AddComplexComponent( (BaseAddon) this, 1341, -3, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 110
			AddComplexComponent( (BaseAddon) this, 1341, -3, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 111
			AddComplexComponent( (BaseAddon) this, 1341, -3, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 112
			AddComplexComponent( (BaseAddon) this, 1341, -2, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 113
			AddComplexComponent( (BaseAddon) this, 1341, -2, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 114
			AddComplexComponent( (BaseAddon) this, 1341, -2, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 115
			AddComplexComponent( (BaseAddon) this, 1341, -2, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 116
			AddComplexComponent( (BaseAddon) this, 1341, -1, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 117
			AddComplexComponent( (BaseAddon) this, 1341, -1, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 118
			AddComplexComponent( (BaseAddon) this, 1341, -1, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 119
			AddComplexComponent( (BaseAddon) this, 1341, -1, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1341, 0, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 121
			AddComplexComponent( (BaseAddon) this, 1341, 0, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1341, 0, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 123
			AddComplexComponent( (BaseAddon) this, 1341, 0, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 124
			AddComplexComponent( (BaseAddon) this, 1341, 1, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 125
			AddComplexComponent( (BaseAddon) this, 1341, 1, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 126
			AddComplexComponent( (BaseAddon) this, 1341, 1, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 127
			AddComplexComponent( (BaseAddon) this, 1341, 1, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1341, 2, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1341, 2, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1341, 2, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1341, 2, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 132
			AddComplexComponent( (BaseAddon) this, 1801, -4, 5, 1, 2895, -1, "solid block of cherry candy", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1801, -3, 5, 1, 2895, -1, "solid block of cherry candy", 1);// 134
			AddComplexComponent( (BaseAddon) this, 1801, -2, 5, 1, 2895, -1, "solid block of cherry candy", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1801, -1, 5, 1, 2895, -1, "solid block of cherry candy", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1801, 2, 5, 1, 2895, -1, "solid block of cherry candy", 1);// 137
			AddComplexComponent( (BaseAddon) this, 2253, -4, 3, 9, 2735, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 2253, -4, 3, 16, 2735, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 2254, -4, 1, 16, 2735, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 2254, -4, 1, 9, 2735, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 2252, -4, 2, 16, 2735, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 2252, -4, 2, 9, 2735, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 7385, -4, 3, 16, 2735, -1, "Glass Shelf", 1);// 144
			AddComplexComponent( (BaseAddon) this, 7385, -4, 2, 16, 2735, -1, "Glass Shelf", 1);// 145
			AddComplexComponent( (BaseAddon) this, 7385, -4, 2, 9, 2735, -1, "Glass Shelf", 1);// 146
			AddComplexComponent( (BaseAddon) this, 7385, -4, 3, 9, 2735, -1, "Glass Shelf", 1);// 147
			AddComplexComponent( (BaseAddon) this, 2253, -4, 0, 9, 2735, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 2253, -4, 0, 16, 2735, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 2254, -4, -2, 16, 2735, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 2254, -4, -2, 9, 2735, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 2252, -4, -1, 16, 2735, -1, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 2252, -4, -1, 9, 2735, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 7385, -4, 0, 16, 2735, -1, "Glass Shelf", 1);// 154
			AddComplexComponent( (BaseAddon) this, 7385, -4, -1, 16, 2735, -1, "Glass Shelf", 1);// 155
			AddComplexComponent( (BaseAddon) this, 7385, -4, -1, 9, 2735, -1, "Glass Shelf", 1);// 156
			AddComplexComponent( (BaseAddon) this, 7385, -4, 0, 9, 2735, -1, "Glass Shelf", 1);// 157
			AddComplexComponent( (BaseAddon) this, 7388, 1, -3, 5, 2735, -1, "Glass", 1);// 161
			AddComplexComponent( (BaseAddon) this, 7388, 0, -3, 5, 2735, -1, "Glass", 1);// 162
			AddComplexComponent( (BaseAddon) this, 7388, -1, -3, 5, 2735, -1, "Glass", 1);// 163
			AddComplexComponent( (BaseAddon) this, 7388, 1, -3, 8, 2735, -1, "Glass", 1);// 167
			AddComplexComponent( (BaseAddon) this, 7388, 0, -3, 8, 2735, -1, "Glass", 1);// 168
			AddComplexComponent( (BaseAddon) this, 7388, -1, -3, 8, 2735, -1, "Glass", 1);// 169
			AddComplexComponent( (BaseAddon) this, 1173, 1, 5, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 170
			AddComplexComponent( (BaseAddon) this, 1173, 0, 5, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 171
			AddComplexComponent( (BaseAddon) this, 10248, -4, 0, 16, 1725, -1, "Cadbury Egg", 1);// 172
			AddComplexComponent( (BaseAddon) this, 2485, -4, -1, 16, 2277, -1, "Blue Malted Robin's Eggs", 1);// 173
			AddComplexComponent( (BaseAddon) this, 2485, -4, 0, 9, 1854, -1, "Dark Chocolate Eggs", 1);// 174
			AddComplexComponent( (BaseAddon) this, 2485, 1, -3, 8, 88, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 2485, 1, -3, 5, 43, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 2485, 0, -3, 5, 53, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 2485, -1, -3, 5, 23, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 2485, 0, -3, 8, 88, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 2485, -1, -3, 8, 78, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 2485, -4, -1, 9, 1858, -1, "Milk Chocolate Eggs", 1);// 181
			AddComplexComponent( (BaseAddon) this, 251, -5, -4, 1, 2891, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 2537, -4, 3, 17, 1169, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 3203, -4, 5, 7, 1165, -1, "Cotton Candy Bush", 1);// 184
			AddComplexComponent( (BaseAddon) this, 3203, -3, 5, 7, 1169, -1, "Cotton Candy Bush", 1);// 185
			AddComplexComponent( (BaseAddon) this, 3203, -2, 5, 7, 1170, -1, "Cotton Candy Bush", 1);// 186
			AddComplexComponent( (BaseAddon) this, 3203, -1, 5, 7, 1167, -1, "Cotton Candy Bush", 1);// 187
			AddComplexComponent( (BaseAddon) this, 3203, 2, 5, 7, 1167, -1, "Cotton Candy Bush", 1);// 188
			AddComplexComponent( (BaseAddon) this, 3743, -3, -3, 0, 1167, -1, "Lady Lizzeta", 1);// 189
			AddComplexComponent( (BaseAddon) this, 3962, -4, -3, 12, 1165, -1, "cotton candy bunny", 1);// 190
			AddComplexComponent( (BaseAddon) this, 3981, -3, -3, 10, 1165, -1, "cotton candy bunny", 1);// 191
			AddComplexComponent( (BaseAddon) this, 14079, -4, -3, 4, 1165, -1, "cotton candy bunny", 1);// 192
			AddComplexComponent( (BaseAddon) this, 10134, -4, -3, 1, 1165, -1, "cotton candy bunny", 1);// 193
			AddComplexComponent( (BaseAddon) this, 10145, -4, -3, 5, 1165, -1, "cotton candy button", 1);// 194
			AddComplexComponent( (BaseAddon) this, 3576, -4, -3, 6, 1165, -1, "cotton candy bunny", 1);// 195
			AddComplexComponent( (BaseAddon) this, 3576, -4, -3, 10, 1165, -1, "cotton candy bunny", 1);// 196
			AddComplexComponent( (BaseAddon) this, 3614, -4, -3, 7, 1165, -1, "cotton candy bunny", 1);// 197
			AddComplexComponent( (BaseAddon) this, 5444, -4, -3, 13, 1165, -1, "cotton candy bunny", 1);// 198
			AddComplexComponent( (BaseAddon) this, 5915, -4, -3, 16, 1165, -1, "cotton candy bunny", 1);// 199
			AddComplexComponent( (BaseAddon) this, 5908, -3, -3, 18, 1165, -1, "cotton candy bunny", 1);// 200
			AddComplexComponent( (BaseAddon) this, 12516, 2, 2, 1, 1165, -1, "easter egg station", 1);// 201
			AddComplexComponent( (BaseAddon) this, 12515, 2, 1, 1, 1165, -1, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 4553, 2, 0, 4, 1167, -1, "Peep Tree", 1);// 203
			AddComplexComponent( (BaseAddon) this, 4104, 2, 2, 9, 0, -1, "warm water", 1);// 204
			AddComplexComponent( (BaseAddon) this, 2448, -4, 2, 9, 1167, -1, "Easter Basket", 1);// 205
			AddComplexComponent( (BaseAddon) this, 1173, 3, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 206
			AddComplexComponent( (BaseAddon) this, 1173, 3, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 207
			AddComplexComponent( (BaseAddon) this, 1173, 3, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 208
			AddComplexComponent( (BaseAddon) this, 1173, 3, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 209
			AddComplexComponent( (BaseAddon) this, 1173, 3, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 210
			AddComplexComponent( (BaseAddon) this, 1173, 3, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 211
			AddComplexComponent( (BaseAddon) this, 1173, 3, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 212
			AddComplexComponent( (BaseAddon) this, 1173, 4, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 213
			AddComplexComponent( (BaseAddon) this, 1173, 4, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 214
			AddComplexComponent( (BaseAddon) this, 1173, 4, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 215
			AddComplexComponent( (BaseAddon) this, 1173, 4, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 216
			AddComplexComponent( (BaseAddon) this, 1173, 4, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 217
			AddComplexComponent( (BaseAddon) this, 1173, 4, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 218
			AddComplexComponent( (BaseAddon) this, 1173, 4, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 219
			AddComplexComponent( (BaseAddon) this, 1173, 5, 4, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 220
			AddComplexComponent( (BaseAddon) this, 1173, 5, 3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 221
			AddComplexComponent( (BaseAddon) this, 1173, 5, 2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 222
			AddComplexComponent( (BaseAddon) this, 1173, 5, 1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 223
			AddComplexComponent( (BaseAddon) this, 1173, 5, 0, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 224
			AddComplexComponent( (BaseAddon) this, 1173, 5, -1, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 225
			AddComplexComponent( (BaseAddon) this, 1173, 5, -2, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 226
			AddComplexComponent( (BaseAddon) this, 1173, 5, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 227
			AddComplexComponent( (BaseAddon) this, 1173, 4, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 228
			AddComplexComponent( (BaseAddon) this, 1173, 3, -3, 1, 2891, -1, "Strawberry Chocolate Floor", 1);// 229
			AddComplexComponent( (BaseAddon) this, 9488, 4, 4, 1, 2891, -1, "strawberry cream wall", 1);// 230
			AddComplexComponent( (BaseAddon) this, 9488, 3, 4, 1, 2891, -1, "strawberry cream wall", 1);// 231
			AddComplexComponent( (BaseAddon) this, 249, 5, -4, 1, 2891, -1, "strawberry cream wall", 1);// 232
			AddComplexComponent( (BaseAddon) this, 249, 4, -4, 1, 2891, -1, "strawberry cream wall", 1);// 233
			AddComplexComponent( (BaseAddon) this, 249, 3, -4, 1, 2891, -1, "strawberry cream wall", 1);// 234
			AddComplexComponent( (BaseAddon) this, 249, 5, 4, 1, 2891, -1, "strawberry cream wall", 1);// 235
			AddComplexComponent( (BaseAddon) this, 1341, 5, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 236
			AddComplexComponent( (BaseAddon) this, 1341, 3, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 237
			AddComplexComponent( (BaseAddon) this, 1341, 3, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 238
			AddComplexComponent( (BaseAddon) this, 1341, 4, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 239
			AddComplexComponent( (BaseAddon) this, 1341, 4, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 240
			AddComplexComponent( (BaseAddon) this, 1341, 3, 3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 241
			AddComplexComponent( (BaseAddon) this, 1341, 3, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 242
			AddComplexComponent( (BaseAddon) this, 1341, 4, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 243
			AddComplexComponent( (BaseAddon) this, 1341, 5, 4, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 244
			AddComplexComponent( (BaseAddon) this, 1341, 5, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 245
			AddComplexComponent( (BaseAddon) this, 1341, 5, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 246
			AddComplexComponent( (BaseAddon) this, 250, 5, -3, 1, 2891, -1, "strawberry cream wall", 1);// 247
			AddComplexComponent( (BaseAddon) this, 250, 5, -2, 1, 2891, -1, "strawberry cream wall", 1);// 248
			AddComplexComponent( (BaseAddon) this, 250, 5, -1, 1, 2891, -1, "strawberry cream wall", 1);// 249
			AddComplexComponent( (BaseAddon) this, 250, 5, 0, 1, 2891, -1, "strawberry cream wall", 1);// 250
			AddComplexComponent( (BaseAddon) this, 250, 5, 1, 1, 2891, -1, "strawberry cream wall", 1);// 251
			AddComplexComponent( (BaseAddon) this, 250, 5, 2, 1, 2891, -1, "strawberry cream wall", 1);// 252
			AddComplexComponent( (BaseAddon) this, 250, 5, 3, 1, 2891, -1, "strawberry cream wall", 1);// 253
			AddComplexComponent( (BaseAddon) this, 250, 5, 4, 1, 2891, -1, "strawberry cream wall", 1);// 254
			AddComplexComponent( (BaseAddon) this, 1341, 4, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 255
			AddComplexComponent( (BaseAddon) this, 1341, 3, 2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 256
			AddComplexComponent( (BaseAddon) this, 1341, 3, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 257
			AddComplexComponent( (BaseAddon) this, 1341, 3, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 258
			AddComplexComponent( (BaseAddon) this, 1341, 3, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 259
			AddComplexComponent( (BaseAddon) this, 1341, 4, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 260
			AddComplexComponent( (BaseAddon) this, 1341, 4, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 261
			AddComplexComponent( (BaseAddon) this, 1341, 4, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 262
			AddComplexComponent( (BaseAddon) this, 1341, 4, 0, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 263
			AddComplexComponent( (BaseAddon) this, 1341, 5, 1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 264
			AddComplexComponent( (BaseAddon) this, 1341, 5, -1, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 265
			AddComplexComponent( (BaseAddon) this, 1341, 5, -3, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 266
			AddComplexComponent( (BaseAddon) this, 1341, 5, -2, 22, 2519, -1, "Strawberry Sprinkle Roof", 1);// 267
			AddComplexComponent( (BaseAddon) this, 1801, 3, 5, 1, 2895, -1, "solid block of cherry candy", 1);// 268
			AddComplexComponent( (BaseAddon) this, 1801, 4, 5, 1, 2895, -1, "solid block of cherry candy", 1);// 269
			AddComplexComponent( (BaseAddon) this, 1801, 5, 5, 1, 2895, -1, "solid block of cherry candy", 1);// 270
			AddComplexComponent( (BaseAddon) this, 3203, 4, 5, 7, 1169, -1, "Cotton Candy Bush", 1);// 271
			AddComplexComponent( (BaseAddon) this, 3203, 5, 5, 7, 1165, -1, "Cotton Candy Bush", 1);// 272
			AddComplexComponent( (BaseAddon) this, 3203, 3, 5, 7, 1170, -1, "Cotton Candy Bush", 1);// 273
			AddComplexComponent( (BaseAddon) this, 3962, 3, -3, 12, 1170, -1, "cotton candy bunny", 1);// 274
			AddComplexComponent( (BaseAddon) this, 3981, 4, -3, 10, 1170, -1, "cotton candy bunny", 1);// 275
			AddComplexComponent( (BaseAddon) this, 14079, 3, -3, 4, 1170, -1, "cotton candy bunny", 1);// 276
			AddComplexComponent( (BaseAddon) this, 10134, 3, -3, 1, 1170, -1, "cotton candy bunny", 1);// 277
			AddComplexComponent( (BaseAddon) this, 10145, 3, -3, 5, 1170, -1, "cotton candy bunny", 1);// 278
			AddComplexComponent( (BaseAddon) this, 3576, 3, -3, 6, 1170, -1, "cotton candy bunny", 1);// 279
			AddComplexComponent( (BaseAddon) this, 3576, 3, -3, 10, 1170, -1, "cotton candy bunny", 1);// 280
			AddComplexComponent( (BaseAddon) this, 3614, 3, -3, 7, 1170, -1, "cotton candy bunny", 1);// 281
			AddComplexComponent( (BaseAddon) this, 5444, 3, -3, 13, 1170, -1, "", 1);// 282
			AddComplexComponent( (BaseAddon) this, 5915, 3, -3, 16, 1170, -1, "cotton candy bunny", 1);// 283
			AddComplexComponent( (BaseAddon) this, 5908, 4, -3, 18, 1170, -1, "cotton candy bunny", 1);// 284
			AddComplexComponent( (BaseAddon) this, 12518, 4, 0, 1, 1165, -1, "easter egg station", 1);// 285
			AddComplexComponent( (BaseAddon) this, 12517, 3, 0, 1, 1165, -1, "", 1);// 286
			AddComplexComponent( (BaseAddon) this, 4009, 3, 2, 18, 0, -1, "Easter Egg Dyes", 1);// 287

		}

		public EasterHouseAddon( Serial serial ) : base( serial )
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

	public class EasterHouseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EasterHouseAddon();
			}
		}

		[Constructable]
		public EasterHouseAddonDeed()
		{
			Name = "EasterHouse";
		}

		public EasterHouseAddonDeed( Serial serial ) : base( serial )
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