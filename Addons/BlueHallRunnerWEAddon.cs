
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
	public class BlueHallRunnerWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2750, -3, 0, 0}, {2750, -2, 0, 0}, {2750, -1, 0, 0}// 1	2	3	
			, {2750, 0, 0, 0}, {2750, 1, 0, 0}, {2750, 2, 0, 0}// 4	5	6	
			, {2750, 3, 0, 0}, {2750, 4, 0, 0}, {2807, -3, -1, 0}// 7	8	9	
			, {2807, -2, -1, 0}, {2807, -1, -1, 0}, {2807, 0, -1, 0}// 10	11	12	
			, {2807, 1, -1, 0}, {2807, 2, -1, 0}, {2807, 3, -1, 0}// 13	14	15	
			, {2807, 4, -1, 0}, {2809, -3, 1, 0}, {2809, -2, 1, 0}// 16	17	18	
			, {2809, -1, 1, 0}, {2809, 0, 1, 0}, {2809, 1, 1, 0}// 19	20	21	
			, {2809, 2, 1, 0}, {2809, 3, 1, 0}, {2809, 4, 1, 0}// 22	23	24	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BlueHallRunnerWEAddonDeed();
			}
		}

		[ Constructable ]
		public BlueHallRunnerWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public BlueHallRunnerWEAddon( Serial serial ) : base( serial )
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

	public class BlueHallRunnerWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BlueHallRunnerWEAddon();
			}
		}

		[Constructable]
		public BlueHallRunnerWEAddonDeed()
		{
			Name = "BlueHallRunnerWE";
		}

		public BlueHallRunnerWEAddonDeed( Serial serial ) : base( serial )
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