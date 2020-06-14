
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
	public class RedBlue1HallRunnerNSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2796, 0, -3, 0}, {2796, 0, -2, 0}, {2796, 0, -1, 0}// 1	2	3	
			, {2796, 0, 0, 0}, {2802, -1, -3, 0}, {2802, -1, -2, 0}// 4	5	6	
			, {2802, -1, -1, 0}, {2802, -1, 0, 0}, {2804, 1, -3, 0}// 7	8	9	
			, {2804, 1, -2, 0}, {2804, 1, -1, 0}, {2804, 1, 0, 0}// 10	11	12	
			, {2796, 0, 1, 0}, {2796, 0, 2, 0}, {2796, 0, 3, 0}// 13	14	15	
			, {2796, 0, 4, 0}, {2802, -1, 1, 0}, {2802, -1, 2, 0}// 16	17	18	
			, {2802, -1, 3, 0}, {2802, -1, 4, 0}, {2804, 1, 1, 0}// 19	20	21	
			, {2804, 1, 2, 0}, {2804, 1, 3, 0}, {2804, 1, 4, 0}// 22	23	24	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RedBlue1HallRunnerNSAddonDeed();
			}
		}

		[ Constructable ]
		public RedBlue1HallRunnerNSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public RedBlue1HallRunnerNSAddon( Serial serial ) : base( serial )
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

	public class RedBlue1HallRunnerNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RedBlue1HallRunnerNSAddon();
			}
		}

		[Constructable]
		public RedBlue1HallRunnerNSAddonDeed()
		{
			Name = "RedBlue1HallRunnerNS";
		}

		public RedBlue1HallRunnerNSAddonDeed( Serial serial ) : base( serial )
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