# -*- coding: utf-8 -*-
"""
Created on Wed Mar 11 18:26:44 2020

@author: Marco He
"""

import numpy as np
import matplotlib.pyplot as plt


def first_example(t):
    x = t*t-2.0*t
    y = t + 1.0
    return x, y


n = 7
t = np.linspace(-2.0, 4.0, n)
x, y = first_example(t)
values = np.transpose((x,y))
np.savetxt('myData.csv',values,fmt='%1.1f;%1.1f')

plt.plot(x, y, linestyle='None', marker='o',
markersize=10.0, color='g')
plt.show()