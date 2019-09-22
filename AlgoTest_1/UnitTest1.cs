using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures2;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTree_1Count_A()
        {
            SimpleTreeNode<int> node_root = new SimpleTreeNode<int>(0, null);
            SimpleTreeNode<int> node_1 = new SimpleTreeNode<int>(1, node_root);
            SimpleTreeNode<int> node_2 = new SimpleTreeNode<int>(2, node_1);
            SimpleTreeNode<int> node_3 = new SimpleTreeNode<int>(3, node_2);

            SimpleTree<int> tree = new SimpleTree<int>(node_root);
            tree.AddChild(node_root, node_1);
            tree.AddChild(node_1, node_2);
            tree.AddChild(node_2, node_3);

            List<int> forest = tree.EvenTrees();
            foreach (Int32 value in forest)
                Assert.IsTrue(value == 1 || value == 2);
        }

        [TestMethod]
        public void TestTree_1Count_B()
        {
            SimpleTree<int> tree = GetTreeA();
            int[] edgeValues = new int[] { 1, 12, 1, 13 };

            int count = 0;
            List<int> forest = tree.EvenTrees();
            foreach (Int32 value in forest)
                Assert.IsTrue(edgeValues[count++] == value);
        }

        [TestMethod]
        public void TestTree_1Count_C()
        {
            SimpleTree<int> tree = GetTreeB();
            int[] edgeValues = new int[] { 1, 11, 12, 121, 1, 12 };

            int count = 0;
            List<int> forest = tree.EvenTrees();
            foreach (Int32 value in forest)
                Assert.IsTrue(edgeValues[count++] == value);
        }

        [TestMethod]
        public void TestTree_1Count_D()
        {
            SimpleTree<int> tree = GetTreeC();
            int[] edgeValues = new int[] { 1111, 11111, 11, 111 };

            int count = 0;
            List<int> forest = tree.EvenTrees();
            foreach (Int32 value in forest)
                Assert.IsTrue(edgeValues[count++] == value);
        }

        [TestMethod]
        public void TestTree_1Count_E()
        {
            SimpleTree<int> tree = GetTreeD();
            int[] edgeValues = new int[] { 1, 12 };

            int count = 0;
            List<int> forest = tree.EvenTrees();
            foreach (Int32 value in forest)
                Assert.IsTrue(edgeValues[count++] == value);
        }

        [TestMethod]
        public void TestTree_1Count_F()
        {
            SimpleTree<int> tree = GetTreeE();
            
            List<int> forest = tree.EvenTrees();
            Assert.IsTrue(forest.Count == 0);
        }

        /*
         * Блоки кода предназначенные для тестирования, 
         *      но не являющиеся тестами
         * 
         * 
         */

        // Возвращает массив узлов для класса SimpleTree<int>
        //
        private SimpleTreeNode<int>[] GetNodesArray_1()
        {
            SimpleTreeNode<int>[] nodes = new SimpleTreeNode<int>[]
            {
                new SimpleTreeNode<int>(1, null),   // 0
                new SimpleTreeNode<int>(11, null),  // 1
                new SimpleTreeNode<int>(12, null),  // 2
                new SimpleTreeNode<int>(13, null),  // 3
                new SimpleTreeNode<int>(111, null), // 4
                new SimpleTreeNode<int>(112, null), // 5
                new SimpleTreeNode<int>(121, null), // 6   
                new SimpleTreeNode<int>(122, null), // 7
                new SimpleTreeNode<int>(123, null), // 8
                new SimpleTreeNode<int>(131, null), // 9
                new SimpleTreeNode<int>(132, null), // 10
                new SimpleTreeNode<int>(133, null), // 11
                new SimpleTreeNode<int>(134, null), // 12
                new SimpleTreeNode<int>(135, null)  // 13
            };
            return nodes;
        }

        // Возвращает массив узлов для класса SimpleTree<int>
        //
        private SimpleTreeNode<int>[] GetNodesArray_2()
        {
            SimpleTreeNode<int>[] nodes = new SimpleTreeNode<int>[]
            {
                new SimpleTreeNode<int>(1, null),   // 0
                new SimpleTreeNode<int>(11, null),  // 1
                new SimpleTreeNode<int>(12, null),  // 2
                new SimpleTreeNode<int>(13, null),  // 3
                new SimpleTreeNode<int>(111, null), // 4
                new SimpleTreeNode<int>(1111, null),// 5
                new SimpleTreeNode<int>(1112, null),// 6
                new SimpleTreeNode<int>(121, null), // 7
                new SimpleTreeNode<int>(122, null), // 8
                new SimpleTreeNode<int>(1211, null) // 9
            };
            return nodes;
        }

        // Возвращает массив узлов для класса SimpleTree<int>
        //
        private SimpleTreeNode<int>[] GetNodesArray_3()
        {
            SimpleTreeNode<int>[] nodes = new SimpleTreeNode<int>[]
            {
                new SimpleTreeNode<int>(1, null),   // 0
                new SimpleTreeNode<int>(11, null),  // 1
                new SimpleTreeNode<int>(111, null),  // 2
                new SimpleTreeNode<int>(1111, null),  // 3
                new SimpleTreeNode<int>(11111, null), // 4
                new SimpleTreeNode<int>(111111, null) // 5
            };
            return nodes;
        }

        // Возвращает массив узлов для класса SimpleTree<int>
        //
        private SimpleTreeNode<int>[] GetNodesArray_4()
        {
            SimpleTreeNode<int>[] nodes = new SimpleTreeNode<int>[]
            {
                new SimpleTreeNode<int>(1, null),    // 0
                new SimpleTreeNode<int>(11, null),   // 1
                new SimpleTreeNode<int>(12, null),   // 2
                new SimpleTreeNode<int>(121, null),  // 3
            };
            return nodes;
        }

        // Возвращает массив узлов для класса SimpleTree<int>
        //
        private SimpleTreeNode<int>[] GetNodesArray_5()
        {
            SimpleTreeNode<int>[] nodes = new SimpleTreeNode<int>[]
            {
                new SimpleTreeNode<int>(1, null),    // 0
                new SimpleTreeNode<int>(11, null),   // 1
                new SimpleTreeNode<int>(12, null),   // 2
                new SimpleTreeNode<int>(121, null),  // 3
                new SimpleTreeNode<int>(122, null),  // 4
            };
            return nodes;
        }

        // Возвращает дерево на основе массива узлов.
        //
        // Структура дерева:
        //      0:1-2-3, 1:4-5, 2:6-7-8, 3:9-10-11-12-13.
        //
        private SimpleTree<int> GetTreeA()
        {
            SimpleTreeNode<int>[] nodes = GetNodesArray_1();

            SimpleTree<int> tree = new SimpleTree<int>(nodes[0]);
            tree.AddChild(tree.Root, nodes[1]);
            tree.AddChild(tree.Root, nodes[2]);
            tree.AddChild(tree.Root, nodes[3]);

            tree.AddChild(nodes[1], nodes[4]);
            tree.AddChild(nodes[1], nodes[5]);
            tree.AddChild(nodes[2], nodes[6]);
            tree.AddChild(nodes[2], nodes[7]);
            tree.AddChild(nodes[2], nodes[8]);
            tree.AddChild(nodes[3], nodes[9]);
            tree.AddChild(nodes[3], nodes[10]);
            tree.AddChild(nodes[3], nodes[11]);
            tree.AddChild(nodes[3], nodes[12]);
            tree.AddChild(nodes[3], nodes[13]);
            return tree;
        }

        // Возвращает дерево на основе массива узлов.
        //
        // Структура дерева:
        //      0:1-2-3, 1:4, 2:7-8, 4:5-6, 7:9
        //
        private SimpleTree<int> GetTreeB()
        {
            SimpleTreeNode<int>[] nodes = GetNodesArray_2();

            SimpleTree<int> tree = new SimpleTree<int>(nodes[0]);
            tree.AddChild(tree.Root, nodes[1]);
            tree.AddChild(tree.Root, nodes[2]);
            tree.AddChild(tree.Root, nodes[3]);

            tree.AddChild(nodes[1], nodes[4]);
            tree.AddChild(nodes[2], nodes[7]);
            tree.AddChild(nodes[2], nodes[8]);
            tree.AddChild(nodes[4], nodes[5]);
            tree.AddChild(nodes[4], nodes[6]);
            tree.AddChild(nodes[7], nodes[9]);
            return tree;
        }

        // Возвращает дерево на основе массива узлов.
        //
        // Структура дерева:
        //      0:1, 1:2, 2:3, 3:4, 4:5 
        //
        private SimpleTree<int> GetTreeC()
        {
            SimpleTreeNode<int>[] nodes = GetNodesArray_3();

            SimpleTree<int> tree = new SimpleTree<int>(nodes[0]);
            tree.AddChild(tree.Root, nodes[1]);

            tree.AddChild(nodes[1], nodes[2]);
            tree.AddChild(nodes[2], nodes[3]);
            tree.AddChild(nodes[3], nodes[4]);
            tree.AddChild(nodes[4], nodes[5]);
            return tree;
        }

        // Возвращает дерево на основе массива узлов.
        //
        // Структура дерева:
        //      0:1-2, 2:3
        //
        private SimpleTree<int> GetTreeD()
        {
            SimpleTreeNode<int>[] nodes = GetNodesArray_4();

            SimpleTree<int> tree = new SimpleTree<int>(nodes[0]);
            tree.AddChild(tree.Root, nodes[1]);
            tree.AddChild(tree.Root, nodes[2]);

            tree.AddChild(nodes[2], nodes[3]);
            return tree;
        }

        // Возвращает дерево на основе массива узлов.
        //
        // Структура дерева:
        //      0:1-2, 2:3-4
        //
        private SimpleTree<int> GetTreeE()
        {
            SimpleTreeNode<int>[] nodes = GetNodesArray_5();

            SimpleTree<int> tree = new SimpleTree<int>(nodes[0]);
            tree.AddChild(tree.Root, nodes[1]);
            tree.AddChild(tree.Root, nodes[2]);

            tree.AddChild(nodes[2], nodes[3]);
            tree.AddChild(nodes[2], nodes[4]);
            return tree;
        }
    }
}
