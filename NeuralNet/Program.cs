// See https://aka.ms/new-console-template for more information

int[] layers = new int[3] { 3, 5, 1 };
string[] activation = new string[2] { "leakyrelu", "leakyrelu" };
NeuralNetwork net = new NeuralNetwork(layers, activation);

for (int i = 0; i < 20000; i++)
{
  net.BackPropagate(new float[] { 0, 0, 0 }, new float[] { 0 });
  net.BackPropagate(new float[] { 1, 0, 0 }, new float[] { 1 });
  net.BackPropagate(new float[] { 0, 1, 0 }, new float[] { 1 });
  net.BackPropagate(new float[] { 0, 0, 1 }, new float[] { 1 });
  net.BackPropagate(new float[] { 1, 1, 0 }, new float[] { 1 });
  net.BackPropagate(new float[] { 0, 1, 1 }, new float[] { 1 });
  net.BackPropagate(new float[] { 1, 0, 1 }, new float[] { 1 });
  net.BackPropagate(new float[] { 1, 1, 1 }, new float[] { 1 });
}

//print("cost: "+net.cost);

//UnityEngine.Debug.Log(net.FeedForward(new float[] { 0, 0, 0 })[0]);
//UnityEngine.Debug.Log(net.FeedForward(new float[] { 1, 0, 0 })[0]);
//UnityEngine.Debug.Log(net.FeedForward(new float[] { 0, 1, 0 })[0]);
//UnityEngine.Debug.Log(net.FeedForward(new float[] { 0, 0, 1 })[0]);
//UnityEngine.Debug.Log(net.FeedForward(new float[] { 1, 1, 0 })[0]);
//UnityEngine.Debug.Log(net.FeedForward(new float[] { 0, 1, 1 })[0]);
//UnityEngine.Debug.Log(net.FeedForward(new float[] { 1, 0, 1 })[0]);
//UnityEngine.Debug.Log(net.FeedForward(new float[] { 1, 1, 1 })[0]);

Console.WriteLine(net.FeedForward(new float[] { 0, 0, 0 })[0]);
Console.WriteLine(net.FeedForward(new float[] { 1, 0, 0 })[0]);
Console.WriteLine(net.FeedForward(new float[] { 0, 1, 0 })[0]);
Console.WriteLine(net.FeedForward(new float[] { 0, 0, 1 })[0]);
Console.WriteLine(net.FeedForward(new float[] { 1, 1, 0 })[0]);
Console.WriteLine(net.FeedForward(new float[] { 0, 1, 1 })[0]);
Console.WriteLine(net.FeedForward(new float[] { 1, 0, 1 })[0]);
Console.WriteLine(net.FeedForward(new float[] { 1, 1, 1 })[0]);

//We want the gate to simulate 3 input or gate (A or B or C)
// 0 0 0    => 0
// 1 0 0    => 1
// 0 1 0    => 1
// 0 0 1    => 1
// 1 1 0    => 1
// 0 1 1    => 1
// 1 0 1    => 1
// 1 1 1    => 1
