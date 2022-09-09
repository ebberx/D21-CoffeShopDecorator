using CoffeShop;

namespace Coffee_tests {
	[TestClass]
	public class CoffeTests {
		[TestMethod]
		public void ProveCost1() {
										// Costs: 
			Beverage b = new Decaf();	// 1.4
			b = new Sugar(b);			// 0.2
			b = new Milk(b);			// 0.15
			
			Assert.AreEqual(b.Cost(), 1.75, 0.1);
		}

		[TestMethod]
		public void ProveCost2() {
											// Costs: 
			Beverage b = new HouseBlend();  // 1.2
			b = new Sugar(b);				// 0.2
			b = new Milk(b);                // 0.15
			b = new Whip(b);				// 0.1

			Assert.AreEqual(b.Cost(), 1.65, 0.1);
		}
	}
}