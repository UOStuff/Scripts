/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class forestweAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new forestweAddonDeed();
			}
		}

		[ Constructable ]
		public forestweAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 3290 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 3291 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -5, -3, 0 );
			ac = new AddonComponent( 3288 );
			AddComponent( ac, -5, -3, 0 );
			ac = new AddonComponent( 3289 );
			AddComponent( ac, -5, -3, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 3286 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 5, -1, 0 );
			ac = new AddonComponent( 3290 );
			AddComponent( ac, 5, -1, 0 );
			ac = new AddonComponent( 3291 );
			AddComponent( ac, 5, -1, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 6, 2, 0 );
			ac = new AddonComponent( 3293 );
			AddComponent( ac, 6, 2, 0 );
			ac = new AddonComponent( 3294 );
			AddComponent( ac, 6, 2, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 3293 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 3294 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3291 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3290 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 3288 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 3289 );
			AddComponent( ac, 3, 3, 0 );

		}

		public forestweAddon( Serial serial ) : base( serial )
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

	public class forestweAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new forestweAddon();
			}
		}

		[Constructable]
		public forestweAddonDeed()
		{
			Name = "forestwe";
		}

		public forestweAddonDeed( Serial serial ) : base( serial )
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