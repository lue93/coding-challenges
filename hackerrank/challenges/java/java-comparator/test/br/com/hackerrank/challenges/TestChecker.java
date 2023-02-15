package br.com.hackerrank.challenges;

import java.util.Arrays;

import org.junit.Assert;
import org.junit.Test;

public class TestChecker {

	@Test
	public void testCase0DescendigOrderByPtsAndAlphabeticNames() {
		Player[] player = new Player[5];
		player[0] = new Player("amy", 100);
		player[1] = new Player("david", 100);
		player[2] = new Player("heraldo", 50);
		player[3] = new Player("aakansha", 75);
		player[4] = new Player("aleksa", 150);

		Checker checker = new Checker();
		Arrays.sort(player, checker);

		Assert.assertEquals("aleksa", player[0].name);
		Assert.assertEquals(150, player[0].score);
		Assert.assertEquals("amy", player[1].name);
		Assert.assertEquals(100, player[1].score);
		Assert.assertEquals("david", player[2].name);
		Assert.assertEquals(100, player[2].score);
		Assert.assertEquals("aakansha", player[3].name);
		Assert.assertEquals(75, player[3].score);
		Assert.assertEquals("heraldo", player[4].name);
		Assert.assertEquals(50, player[4].score);

	}

	@Test
	public void testCase1() {
		Player[] player = new Player[5];
		player[0] = new Player("ab", 6);
		player[1] = new Player("bcc", 0);
		player[2] = new Player("ade", 5);
		player[3] = new Player("cab", 2);
		player[4] = new Player("dee", 0);

		Checker checker = new Checker();
		Arrays.sort(player, checker);
		
		Assert.assertEquals("ab", player[0].name);
		Assert.assertEquals(6, player[0].score);
		Assert.assertEquals("ade", player[1].name);
		Assert.assertEquals(5, player[1].score);
		Assert.assertEquals("cab", player[2].name);
		Assert.assertEquals(2, player[2].score);
		Assert.assertEquals("bcc", player[3].name);
		Assert.assertEquals(0, player[3].score);
		Assert.assertEquals("dee", player[4].name);
		Assert.assertEquals(0, player[4].score);
		
	}

	@Test
	public void testCase2() {
		Player[] player = new Player[5];
		player[0] = new Player("ab", 6);
		player[1] = new Player("b", 0);
		player[2] = new Player("ade", 5);
		player[3] = new Player("cab", 2);
		player[4] = new Player("d", 0);

		Checker checker = new Checker();
		Arrays.sort(player, checker);
		
		Assert.assertEquals("ab", player[0].name);
		Assert.assertEquals(6, player[0].score);
		Assert.assertEquals("ade", player[1].name);
		Assert.assertEquals(5, player[1].score);
		Assert.assertEquals("cab", player[2].name);
		Assert.assertEquals(2, player[2].score);
		Assert.assertEquals("b", player[3].name);
		Assert.assertEquals(0, player[3].score);
		Assert.assertEquals("d", player[4].name);
		Assert.assertEquals(0, player[4].score);
		
	}
	
	
	@Test
	public void testCase3() {
		Player[] player = new Player[5];
		player[0] = new Player("abaa", 6);
		player[1] = new Player("bcdd", 0);
		player[2] = new Player("aade", 5);
		player[3] = new Player("ccc", 2);
		player[4] = new Player("eed", 0);

		Checker checker = new Checker();
		Arrays.sort(player, checker);
		
		Assert.assertEquals("abaa", player[0].name);
		Assert.assertEquals(6, player[0].score);
		Assert.assertEquals("aade", player[1].name);
		Assert.assertEquals(5, player[1].score);
		Assert.assertEquals("ccc", player[2].name);
		Assert.assertEquals(2, player[2].score);
		Assert.assertEquals("bcdd", player[3].name);
		Assert.assertEquals(0, player[3].score);
		Assert.assertEquals("eed", player[4].name);
		Assert.assertEquals(0, player[4].score);
		
	}
	
	@Test
	public void testCase4() {
		Player[] player = new Player[5];
		player[0] = new Player("a", 6);
		player[1] = new Player("b", 6);
		player[2] = new Player("a", 5);
		player[3] = new Player("a", 5);
		player[4] = new Player("e", 0);

		Checker checker = new Checker();
		Arrays.sort(player, checker);
		
		Assert.assertEquals("a", player[0].name);
		Assert.assertEquals(6, player[0].score);
		Assert.assertEquals("b", player[1].name);
		Assert.assertEquals(6, player[1].score);
		Assert.assertEquals("a", player[2].name);
		Assert.assertEquals(5, player[2].score);
		Assert.assertEquals("a", player[3].name);
		Assert.assertEquals(5, player[3].score);
		Assert.assertEquals("e", player[4].name);
		Assert.assertEquals(0, player[4].score);
		
	}
}
