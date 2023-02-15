package br.com.hackerrank.challenges;

public class Player {
	String name;
	int score;

	Player(String name, int score) {
		this.name = name;
		this.score = score;
	}
	
	@Override
	public int hashCode() {
		return name.hashCode() + score;
	}
}
