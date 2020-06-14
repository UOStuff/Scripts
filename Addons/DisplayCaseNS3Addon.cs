
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
	public class DisplayCaseNS3Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2822, 0, 2, 0}, {2823, 0, 1, 0}, {2823, 0, 0, 0}// 1	2	3	
			, {2824, 0, -1, 0}, {2821, 0, -1, 3}, {2820, 0, 0, 3}// 4	5	6	
			, {2820, 0, 1, 3}, {2819, 0, 2, 3}// 7	8	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DisplayCaseNS3AddonDeed();
			}
		}

		[ Constructable ]
		public DisplayCaseNS3Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public DisplayCaseNS3Addon( Serial serial ) : base( serial )
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

	public class DisplayCaseNS3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DisplayCaseNS3Addon();
			}
		}

		[Constructable]
		public DisplayCaseNS3AddonDeed()
		{
			Name = "DisplayCaseNS3";
		}

		public DisplayCaseNS3AddonDeed( Serial serial ) : base( serial )
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