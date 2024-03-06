package lab2.builder;

import java.util.ArrayList;

public class Builder {
	private ArrayList<Integer> sequence;
	
	public Builder(int size) {
		sequence = new ArrayList<Integer>(size + 1);
		for(int i = 0; i <= size; i++)
			sequence.add(i);
	}
	
	public void reverse(int l, int r)
	{
		for(int i=l; i <= (l+r)/2 ;i++) {
			int temp = sequence.get(i);
			sequence.set(i, sequence.get(r - (i - l)));
			sequence.set(r - (i - l), temp);
		}
	}
	
	public void resize(int size) {
		if(size >= sequence.size())
		for(int i = sequence.size() ; i<= size; i++) {
			sequence.add(i);
		}
	}

	public void at(int index) {
		System.out.println(sequence.get(index));
	}
	
	public void print() {
		for(Integer value : sequence) {
			System.out.println(value + " ");
		}
	}
}
