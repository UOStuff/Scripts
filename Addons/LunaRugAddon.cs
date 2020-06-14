
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
	public class LunaRugAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2748, -1, -2, 0}, {2748, -1, -1, 0}, {2748, -1, 0, 0}// 1	2	3	
			, {2748, -1, 1, 0}, {2748, -1, 2, 0}, {2748, 0, -2, 0}// 4	5	6	
			, {2748, 0, -1, 0}, {2748, 0, 0, 0}, {2748, 0, 1, 0}// 7	8	9	
			, {2748, 0, 2, 0}, {2748, 1, -2, 0}, {2748, 1, -1, 0}// 10	11	12	
			, {2748, 1, 0, 0}, {2748, 1, 1, 0}, {2748, 1, 2, 0}// 13	14	15	
			, {2748, 2, -2, 0}, {2748, 2, -1, 0}, {2748, 2, 0, 0}// 16	17	18	
			, {2748, 2, 1, 0}, {2748, 2, 2, 0}, {2748, 3, -2, 0}// 19	20	21	
			, {2748, 3, -1, 0}, {2748, 3, 0, 0}, {2748, 3, 1, 0}// 22	23	24	
			, {2748, 3, 2, 0}, {2748, -2, -2, 0}, {2748, -2, -1, 0}// 25	26	27	
			, {2748, -2, 0, 0}, {2748, -2, 1, 0}, {2748, -2, 2, 0}// 28	29	30	
			, {2741, 4, -2, 0}, {2741, 4, -1, 0}, {2741, 4, 0, 0}// 31	32	33	
			, {2741, 4, 1, 0}, {2741, 4, 2, 0}, {2744, -4, -4, 0}// 34	35	36	
			, {2745, 4, -4, 0}, {2743, -4, -2, 0}, {2743, -4, -1, 0}// 37	38	39	
			, {2743, -4, 0, 0}, {2743, -4, 1, 0}, {2743, -4, 2, 0}// 40	41	42	
			, {2740, -2, -4, 0}, {2740, -1, -4, 0}, {2740, 0, -4, 0}// 43	44	45	
			, {2740, 1, -4, 0}, {2740, 2, -4, 0}, {2740, 3, -4, 0}// 46	47	48	
			, {2740, -3, -4, 0}, {2743, -4, -3, 0}, {2741, 4, -3, 0}// 49	50	51	
			, {2739, 3, -3, 0}, {2739, -3, -3, 0}, {2739, -2, -3, 0}// 52	53	54	
			, {2739, -1, -3, 0}, {2739, 0, -3, 0}, {2739, 1, -3, 0}// 55	56	57	
			, {2739, 2, -3, 0}, {2739, -3, -2, 0}, {2739, -3, -1, 0}// 58	59	60	
			, {2739, -3, 0, 0}, {2739, -3, 1, 0}, {2739, -3, 2, 0}// 61	62	63	
			, {2748, -1, 3, 0}, {2748, 0, 3, 0}, {2748, 1, 3, 0}// 64	65	66	
			, {2748, 2, 3, 0}, {2748, 3, 3, 0}, {2748, -2, 3, 0}// 67	68	69	
			, {2741, 4, 3, 0}, {2742, -2, 4, 0}, {2742, -1, 4, 0}// 70	71	72	
			, {2742, 0, 4, 0}, {2742, 1, 4, 0}, {2742, 2, 4, 0}// 73	74	75	
			, {2742, 3, 4, 0}, {2746, 4, 4, 0}, {2747, -4, 4, 0}// 76	77	78	
			, {2743, -4, 3, 0}, {2742, -3, 4, 0}, {2739, -3, 3, 0}// 79	80	81	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LunaRugAddonDeed();
			}
		}

		[ Constructable ]
		public LunaRugAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public LunaRugAddon( Serial serial ) : base( serial )
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

	public class LunaRugAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LunaRugAddon();
			}
		}

		[Constructable]
		public LunaRugAddonDeed()
		{
			Name = "LunaRug";
		}

		public LunaRugAddonDeed( Serial serial ) : base( serial )
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