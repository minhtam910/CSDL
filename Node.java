public class HelloWorld{
    class Node
{
    private int key;
    private Node left;
    private Node right;
    private int size;
    private int height;

    public Node()
    {

    }
    public Node(int key, Node left, Node right, int size, int height)
    {
        this.key = key;
        this.left = left;
        this.right = right;
        this.size = size;
        this.height = height;
    }
    public Node(int key)
    {
        this.key = key;
        this.left = null;
        this.right = null;
        this.size = 1;
        this.height = 1;  
    }

    public int getKey()
    {
        return key;
    }
    public int getSize()
    {
        return size;
    }
    public Node getLeft()
    {
        return left;
    }
    public Node getRight()
    {
        return right;
    }
    public int getHeight()
    {
        return height;
    }

    public void setLeft(Node left)
    {
        this.left = left;
    }
    public void setRight(Node right)
    {
        this.right = right;
    }
    public void setKey(int key)
    {
        this.key = key;
    }
    public void setSize(int size)
    {
        this.size = size;
    }
    public void setHeight(int height)
    {
        this.height = height;
    }

    public void addNode(Node node)
    {
        if(node.getKey() <= this.key)
            if(left == null)
            {
                this.left = node;
                this.size = node.getSize() + 1;
            }
        else
        {
            if(right == null)
            {
                this.right = node;
                this.size = node.getSize() + 1;
            }
        }
    }

    public Node insertNode(Node node, int key)
    {
        if (node == null)
            return new Node(key);
        else
        {
            if (key < node.getKey())
            {
                node.setLeft(insertNode(node.getLeft(),key));
            }
            if (key > node.getKey())
            {
                node.setRight(insertNode(node.getRight(),key)) ;
            }
            else
                node.setKey(key);
        node.setSize(1+node.getLeft().getSize() + node.getRight().getSize());
        node.setHeight(1 + Math.max(node.getLeft().getHeight(),node.getRight().getHeight()));
        return node;
        }
    }
	
	public void nlr(Node x)
	{
		if (x!= null)
		{
			System.out.println(x.getKey() + " ");
			nlr(x.getLeft());
			nlr(x.getRight());
		}
	}
	
	public void lnr(Node x)
	{
		if (x!= null)
		{
			nlr(x.getLeft());
			System.out.println(x.getKey() + " ");
			nlr(x.getRight());
		}
	}
	
	public void lrn(Node x)
	{
		if (x!= null)
		{
			nlr(x.getLeft());
			nlr(x.getRight());
			System.out.println(x.getKey() + " ");
		}
	}
	
	public Node search(Node x, int key)
	{
		if(x == null)
			return null;
		if(key < x.getKey())
		{
			return search(x.getLeft(),key);
		}
		if(key > x.getKey())
		{
			return search(x.getRight(),key);
		}
		else
			return x;
	}
	
	public void createTree(String strKey)
	{
		String[] keys = strKey.split(" ");
		int k;
		k = Integer.parseInt(keys[0]);
		Node x = new Node(k);
		for (int i = 1; i < keys.length; i++)
		{
			k = Integer.parseInt(keys[i]);
			insertNode(x,k);
		}
	}
	
	
	
    public Node getMin(Node node)
    {
        if(node.getLeft() == null)
            return node;
        else
            return getMin(node.getLeft());
    }
	
	public Node getMax(Node node)
    {
        if(node.getRight() == null)
            return node;
        else
            return getMax(node.getRight());
    }

    public Node deleteMin(Node node)
    {
        if(node.getLeft() == null)
        {
            return node.getRight();
        }
        node.setLeft(deleteMin(node.getLeft()));
        node.setSize(node.getLeft().getSize() + node.getRight().getSize() + 1);
        node.setHeight(1 + Math.max(node.getLeft().getHeight(), node.getRight().getHeight()));
        return node;
    }
    public Node deleteMax(Node node)
    {
        if (node.getRight() == null)
        {
            return node.getLeft();
        }
        node.setRight(deleteMax(node.getRight()));
        node.setSize(node.getLeft().getSize() + node.getRight().getSize() + 1);
        node.setHeight(1 + Math.max(node.getLeft().getHeight(), node.getRight().getHeight()));
        return node;
    }

    public Node deleteNode(Node node,int key)
    {
        if (node == null)
            return null;
        if (key < node.getLeft().getKey())
            node.setLeft(deleteNode(node.getLeft(),key));
        else if (key > node.getLeft().getKey())
            node.setRight(deleteNode(node.getRight(),key));
        else
        {
            if(node.getRight() == null)
                return node.getLeft();
            if(node.getLeft() == null)
                return node.getRight();
            Node temp = node;
            node = getMin(temp.getRight());
            node.setRight(deleteMin(temp.getRight()));
            node.setLeft(temp.getLeft());
        }
        return node;
    }

    public Node deleteNode1(Node node, int key)
    {
        if (node == null)
            return null;
        if (key < node.getLeft().getKey())
            node.setLeft(deleteNode(node.getLeft(),key));
        else if (key > node.getLeft().getKey())
            node.setRight(deleteNode(node.getRight(),key));
        else
        {
            if(node.getRight() == null)
                return node.getLeft();
            if(node.getLeft() == null)
                return node.getRight();
            Node temp = node;
            node = getMax(temp.getLeft());
            node.setLeft(deleteMax(temp.getLeft()));
            node.setRight(temp.getRight());
        }
        return node;
    }

    

    public Node findKey(Node node, int key)
    {
        if (node.getKey() > key)
            return findKey(node.getLeft(),key);
        if (node.getKey() < key)
            return findKey(node.getRight(),key);
        else
            return node;
    }

    public int checkBalance(Node x)
    {
        return x.getLeft().getHeight() - x.getRight().getHeight();
    }

    public Node rotateLeft(Node x)
    {
        Node y = x.getRight();
        x.setRight(y.getLeft());
        y.setLeft(x);
        y.setSize(x.getSize());
        x.setSize(1 + x.getLeft().getSize() + x.getRight().getSize());
        x.setHeight(1 + Math.max(x.getLeft().getHeight(),x.getRight().getHeight()));  
        y.setHeight(1 + Math.max(y.getLeft().getHeight(),y.getRight().getHeight()));  
        return y;
    }

    public Node rotateRight(Node x)
    {
        Node y = x.getLeft();
        x.setLeft(y.getRight());
        y.setRight(x);
        y.setSize(x.getSize());
        x.setSize(1 + x.getLeft().getSize() + x.getRight().getSize());
        x.setHeight(1 + Math.max(x.getLeft().getHeight(),x.getRight().getHeight()));  
        y.setHeight(1 + Math.max(y.getLeft().getHeight(),y.getRight().getHeight()));  
        return y;
    }

    public Node balance(Node x)
    {
        if(checkBalance(x) < -1)
        {
            if(checkBalance(x.getRight()) > 0)
            {
                x.setRight(rotateRight(x.getRight()));
            }
            x = rotateLeft(x);
        }
        else if (checkBalance(x) > 1){
            if(checkBalance(x.getLeft()) < 0)
            {
                x.setLeft(rotateLeft(x.getLeft()));
            }
            x = rotateRight(x);
        }
        return x;
    }
}


     public static void main(String []args){
        System.out.println("Hello World");
     }
}