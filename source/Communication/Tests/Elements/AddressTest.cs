using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Elements
{
	[TestFixture]
	public class AddressTest : HelperTest
	{
		[Test]
		public void Create()
		{
			var type = new Address();
			Assert.IsNullOrEmpty(type.street);
			Assert.IsNullOrEmpty(type.house);
			Assert.IsNullOrEmpty(type.building);
			Assert.IsNullOrEmpty(type.flat);
			Assert.IsNullOrEmpty(type.settlement);
			Assert.IsNullOrEmpty(type.district);
			Assert.IsNullOrEmpty(type.region);
			Assert.IsNullOrEmpty(type.country);
			Assert.IsNullOrEmpty(type.postсode);
			Assert.IsNullOrEmpty(type.postbox);
			Assert.IsNullOrEmpty(type.nontypical);
			Assert.IsNullOrEmpty(type.Value);
		}

		[Test]
		[Pairwise]
		public void Init(
			[Values("Советская", "Молодежная", "Центральная")] string street,
			[Values("2", "6c2", "12/31")] string house,
			[Values(null, "a", "6", "10")] string building
			)
		{
			var type = new Address();
			type.street = street;
			type.house = house;
			type.building = building;

			var xml = type.Serialize();
			Assert.IsNotNullOrEmpty(xml);
			var obj = Address.Deserialize(xml);
			EqualTo(obj, type);
		}

		[Test]
		[Pairwise]
		public void Init2(
			[Values(null, "3", "17", "56")] string flat,
			[Values("Москва", "Колобовщина", "Машкины")] string settlement,
			[Values("Центральный район", "Советский район", "Ленинский район")] string district
			)
		{
			var type = new Address();
			type.flat = flat;
			type.settlement = settlement;
			type.district = district;

			var xml = type.Serialize();
			Assert.IsNotNullOrEmpty(xml);
			var obj = Address.Deserialize(xml);
			EqualTo(obj, type);
		}

		[Test]
		[Pairwise]
		public void Init3(
			[Values("Республика", "Край", "Область")] string region,
			[Values("Россия","Германия", "Китай")] string country,
			[Values("846194", "941349", "9175453")] string postсode
			)
		{
			var type = new Address();
			type.region = region;
			type.country = country;
			type.postсode = postсode;

			var xml = type.Serialize();
			Assert.IsNotNullOrEmpty(xml);
			var obj = Address.Deserialize(xml);
			EqualTo(obj, type);
		}

		[Test]
		[Pairwise]
		public void Init4(
			[Values(null, "а/я 5", "а/я 15")] string postbox,
			[Values(null, "прочие", "элементы")]string nontypical
			)
		{
			var type = new Address();
			type.postbox = postbox;
			type.nontypical = nontypical;

			var xml = type.Serialize();
			Assert.IsNotNullOrEmpty(xml);
			var obj = Address.Deserialize(xml);
			EqualTo(obj, type);
		}

		[Test]
		public void Serialize()
		{
			var type = new AcknowledgementType();
			var xml = type.Serialize();
			Assert.IsNotNullOrEmpty(xml);
			var obj = AcknowledgementType.Deserialize(xml);
			EqualTo(obj, type);
		}
	}
}
