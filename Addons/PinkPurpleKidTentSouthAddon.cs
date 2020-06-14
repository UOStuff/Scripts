
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
	public class PinkPurpleKidTentSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {875, -6, -6, 0}// 24	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PinkPurpleKidTentSouthAddonDeed();
			}
		}

		[ Constructable ]
		public PinkPurpleKidTentSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 873, -5, 6, 0, 21, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 873, -4, 6, 0, 11, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 873, -3, 6, 0, 21, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 873, -2, 6, 0, 11, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 876, -6, 6, 0, 11, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 881, -5, -6, 0, 21, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 881, -4, -6, 0, 11, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 881, -3, -6, 0, 21, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 881, -2, -6, 0, 11, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 881, -1, -6, 0, 21, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 881, 0, -6, 0, 11, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 881, 1, -6, 0, 21, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 880, -6, -5, 0, 21, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 880, -6, -4, 0, 11, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 880, -6, -3, 0, 21, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 880, -6, -2, 0, 11, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 880, -6, -1, 0, 21, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 880, -6, 0, 0, 11, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 880, -6, 1, 0, 21, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 880, -6, 2, 0, 11, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 880, -6, 3, 0, 21, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 880, -6, 4, 0, 11, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 880, -6, 5, 0, 21, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1541, 1, 0, 35, 21, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1540, 1, 1, 35, 11, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1542, -5, -5, 20, 21, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1542, -4, -4, 23, 11, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1542, -3, -3, 26, 21, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1542, -2, -2, 29, 11, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1542, -1, -1, 32, 21, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1542, 0, 0, 35, 11, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1543, -5, 6, 20, 11, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1543, -4, 5, 23, 21, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1543, -3, 4, 26, 11, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1543, -2, 3, 29, 21, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1543, -1, 2, 32, 11, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1543, 0, 1, 35, 21, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1535, -5, -4, 20, 11, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1535, -5, -3, 20, 21, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1535, -5, -2, 20, 11, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1535, -5, -1, 20, 21, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1535, -5, 0, 20, 11, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1535, -5, 1, 20, 21, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1535, -5, 2, 20, 11, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1535, -5, 3, 20, 21, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1535, -5, 4, 20, 11, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1535, -5, 5, 20, 21, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1535, -4, -3, 23, 21, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1535, -4, -2, 23, 11, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1535, -4, -1, 23, 21, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1535, -4, 0, 23, 11, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1535, -4, 1, 23, 21, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1535, -4, 2, 23, 11, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 1535, -4, 3, 23, 21, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 1535, -4, 4, 23, 11, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1535, -3, -2, 26, 11, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1535, -3, -1, 26, 21, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1535, -3, 0, 26, 11, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1535, -3, 1, 26, 21, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1535, -3, 2, 26, 11, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1535, -3, 3, 26, 21, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1535, -2, -1, 29, 21, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1535, -2, 0, 29, 11, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1535, -2, 1, 29, 21, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1535, -2, 2, 29, 11, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1535, -1, 0, 32, 11, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 1535, -1, 1, 32, 21, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1536, -4, -5, 20, 11, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1536, -3, -5, 20, 21, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1536, -2, -5, 20, 11, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1536, -1, -5, 20, 21, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1536, 0, -5, 20, 11, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1536, 1, -5, 20, 21, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1536, -3, -4, 23, 21, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1536, -2, -4, 23, 11, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 1536, -1, -4, 23, 21, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 1536, 0, -4, 23, 11, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 1536, 1, -4, 23, 21, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 1536, -2, -3, 26, 11, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1536, -1, -3, 26, 21, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1536, 0, -3, 26, 11, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1536, 1, -3, 26, 21, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 1536, -1, -2, 29, 21, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1536, 0, -2, 29, 11, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 1536, 1, -2, 29, 21, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 1536, 0, -1, 32, 11, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 1536, 1, -1, 32, 21, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 1537, -4, 6, 20, 21, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 1537, -3, 6, 20, 11, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 1537, -2, 6, 20, 21, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 1537, -1, 6, 20, 11, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 1537, 0, 6, 20, 21, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 1537, 1, 6, 20, 11, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 1537, -3, 5, 23, 11, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 1537, -2, 5, 23, 21, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 1537, -1, 5, 23, 11, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 1537, 0, 5, 23, 21, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 1537, 1, 5, 23, 11, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 1537, -2, 4, 26, 21, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 1537, -1, 4, 26, 11, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 1537, 0, 4, 26, 21, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 1537, 1, 4, 26, 11, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 1537, -1, 3, 29, 11, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 1537, 0, 3, 29, 21, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 1537, 1, 3, 29, 11, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 1537, 0, 2, 32, 21, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1537, 1, 2, 32, 11, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 873, 2, 6, 0, 11, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 873, 3, 6, 0, 21, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 873, 4, 6, 0, 11, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 873, 5, 6, 0, 21, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 872, 6, 6, 0, 11, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 874, 6, -5, 0, 21, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 874, 6, -4, 0, 11, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 874, 6, -3, 0, 21, -1, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 874, 6, -2, 0, 11, -1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 874, 6, -1, 0, 21, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 874, 6, 0, 0, 11, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 874, 6, 1, 0, 21, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 874, 6, 2, 0, 11, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 874, 6, 3, 0, 21, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 874, 6, 4, 0, 11, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 874, 6, 5, 0, 21, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 877, 6, -6, 0, 11, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 881, 2, -6, 0, 11, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 881, 3, -6, 0, 21, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 881, 4, -6, 0, 11, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 881, 5, -6, 0, 21, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1540, 6, 6, 20, 21, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1540, 5, 5, 23, 11, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1540, 4, 4, 26, 21, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 1540, 3, 3, 29, 11, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1540, 2, 2, 32, 21, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 1541, 6, -5, 20, 11, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1541, 5, -4, 23, 21, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1541, 4, -3, 26, 11, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1541, 3, -2, 29, 21, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1541, 2, -1, 32, 11, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 1536, 2, -5, 20, 11, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 1536, 3, -5, 20, 21, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1536, 4, -5, 20, 11, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 1536, 5, -5, 20, 21, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 1536, 2, -4, 23, 11, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 1536, 3, -4, 23, 21, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 1536, 4, -4, 23, 11, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 1536, 2, -3, 26, 11, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 1536, 3, -3, 26, 21, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 1536, 2, -2, 29, 11, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 1537, 2, 6, 20, 21, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 1537, 3, 6, 20, 11, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 1537, 4, 6, 20, 21, -1, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 1537, 5, 6, 20, 11, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 1537, 2, 5, 23, 21, -1, "", 1);// 154
			AddComplexComponent( (BaseAddon) this, 1537, 3, 5, 23, 11, -1, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 1537, 4, 5, 23, 21, -1, "", 1);// 156
			AddComplexComponent( (BaseAddon) this, 1537, 2, 4, 26, 21, -1, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 1537, 3, 4, 26, 11, -1, "", 1);// 158
			AddComplexComponent( (BaseAddon) this, 1537, 2, 3, 29, 21, -1, "", 1);// 159
			AddComplexComponent( (BaseAddon) this, 1538, 6, -4, 20, 21, -1, "", 1);// 160
			AddComplexComponent( (BaseAddon) this, 1538, 6, -3, 20, 11, -1, "", 1);// 161
			AddComplexComponent( (BaseAddon) this, 1538, 6, -2, 20, 21, -1, "", 1);// 162
			AddComplexComponent( (BaseAddon) this, 1538, 6, -1, 20, 11, -1, "", 1);// 163
			AddComplexComponent( (BaseAddon) this, 1538, 6, 0, 20, 21, -1, "", 1);// 164
			AddComplexComponent( (BaseAddon) this, 1538, 6, 1, 20, 11, -1, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 1538, 6, 2, 20, 21, -1, "", 1);// 166
			AddComplexComponent( (BaseAddon) this, 1538, 6, 3, 20, 11, -1, "", 1);// 167
			AddComplexComponent( (BaseAddon) this, 1538, 6, 4, 20, 21, -1, "", 1);// 168
			AddComplexComponent( (BaseAddon) this, 1538, 6, 5, 20, 11, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 1538, 5, -3, 23, 11, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 1538, 5, -2, 23, 21, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 1538, 5, -1, 23, 11, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 1538, 5, 0, 23, 21, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 1538, 5, 1, 23, 11, -1, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 1538, 5, 2, 23, 21, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 1538, 5, 3, 23, 11, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 1538, 5, 4, 23, 21, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 1538, 4, -2, 26, 21, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 1538, 4, -1, 26, 11, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 1538, 4, 0, 26, 21, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 1538, 4, 1, 26, 11, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 1538, 4, 2, 26, 21, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 1538, 4, 3, 26, 11, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 1538, 3, -1, 29, 11, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 1538, 3, 0, 29, 21, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 1538, 3, 1, 29, 11, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 1538, 3, 2, 29, 21, -1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 1538, 2, 0, 32, 21, -1, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 1538, 2, 1, 32, 11, -1, "", 1);// 189

		}

		public PinkPurpleKidTentSouthAddon( Serial serial ) : base( serial )
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

	public class PinkPurpleKidTentSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PinkPurpleKidTentSouthAddon();
			}
		}

		[Constructable]
		public PinkPurpleKidTentSouthAddonDeed()
		{
			Name = "PinkPurpleKidTentSouth";
		}

		public PinkPurpleKidTentSouthAddonDeed( Serial serial ) : base( serial )
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