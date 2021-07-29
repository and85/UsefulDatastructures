package com.company;

// QuickUnionFind implementation taken from https://www.coursera.org/learn/algorithms-part1/programming/Lhp5z/percolation
public class QuickUnionUF {
    private int[] parent;
    private int count;

    public QuickUnionUF(int n) {
        this.parent = new int[n];
        this.count = n;

        for(int i = 0; i < n; this.parent[i] = i++) {
        }

    }

    public int count() {
        return this.count;
    }

    // returns component number where p is located
    public int find(int p) {
        this.validate(p);

        while(p != this.parent[p]) {
            p = this.parent[p];
        }

        return p;
    }

    private void validate(int p) {
        int n = this.parent.length;
        if (p < 0 || p >= n) {
            throw new IllegalArgumentException("index " + p + " is not between 0 and " + (n - 1));
        }
    }

    /** @deprecated */
    @Deprecated
    public boolean connected(int p, int q) {
        return this.find(p) == this.find(q);
    }

    public void union(int p, int q) {
        int rootP = this.find(p);
        int rootQ = this.find(q);
        if (rootP != rootQ) {
            this.parent[rootP] = rootQ;
            --this.count;
        }
    }

    public static void main(String[] args) {

        QuickUnionUF uf = new QuickUnionUF(2);

        int p = 0;
        int q = 1;
        if (uf.find(p) != uf.find(q)) {
            uf.union(p, q);
        }

        //System.out.println(uf.count() + " components");

        //
        int[][] connections = new int[][]
                {
                        new int[] { 0, 1 },
                        new int[] { 0, 2 },
                        new int[] { 3, 4 },
                        new int[] { 2, 3 }
                };

        MakeConnected(6, connections);
    }

    public static void MakeConnected(int n, int[][] connections)
    {
        QuickUnionUF uf = new QuickUnionUF(n);

        int p;
        int q;
        for (int i = 0; i < connections.length; i++)
        {
            p = connections[i][0];
            q = connections[i][1];
            if (uf.find(p) != uf.find(q))
            {
                uf.union(p, q);
            }
        }

        System.out.println(uf.count() + " components");
    }
}
