using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_tutorial;

internal class Test {

    public int Id { get; private set; } = 100;

    private int _count = 10;
    public int Count { 
        get {
            return _count;
        } 
        set {
            if(value >= 0) {
                _count = value;
            }
        }
    }

    public Test(int i) { }
    public Test() { }
}
