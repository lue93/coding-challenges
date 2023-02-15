package br.com.hackerrank.challenges;

import java.util.Comparator;

public class Checker implements Comparator<Player>{

	@Override
	public int compare(Player o1, Player o2) {
		if(o1.score == o2.score) { 
			return o1.name.compareTo(o2.name); // < asc = a b c d
		}
		return (o1.score > o2.score) ? -1 : 1; // > desc = 4 3 2 1
	}

}
