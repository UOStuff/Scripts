/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BakedRoadRunnerAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BakedRoadRunnerAddonDeed();
			}
		}

		[ Constructable ]
		public BakedRoadRunnerAddon()
		{
			AddComponent( new AddonComponent( 2519 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 2488 ), 0, 0, 1 );
			AddonComponent ac;
			ac = new AddonComponent( 2488 );
			AddComponent( ac, 0, 0, 1 );

		}

		public BakedRoadRunnerAddon( Serial serial ) : base( serial )
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

	public class BakedRoadRunnerAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BakedRoadRunnerAddon();
			}
		}

		[Constructable]
		public BakedRoadRunnerAddonDeed()
		{
			Name = "BakedRoadRunner";
		}

		public BakedRoadRunnerAddonDeed( Serial serial ) : base( serial )
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