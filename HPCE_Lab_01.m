%% HPCE Lab 01
%% Nonlinear Pneumatic Resistances
% Ex. 1: Measurement of the Real Flow
close all; clear; clc;
V = 1;                      % L
T = 29.62;                  % sec
ta = 22;                    % degC

DeltaP2 = 6*1e-3;
DeltaP1 = 1.5*1e-3;
DeltaP = (DeltaP2+DeltaP1)/2 ;   % kg/m^2

p1 = 1.5*1e5;                    % N/m^2

C_d = 0.632897;
d0 = 11.565*1e-3;               % m
xi = 1.4;
R = 2927*1e-2;              % m/degK
g = 9.81;                   % m/s^2
T1 = 273.15 + ta;           % deg K

Q_vm = V*1e-3/T;            % m^3/sec
gamma_air = 1.293;          % kgf/m^3
Q_gm = gamma_air * Q_vm;    % kgf/sec
string = strcat('The volumetric flow Q_vm is:  ',num2str(Q_vm),'  and the gravimetric flow Q_gm is: ',num2str(Q_gm))

% Ex. 2: Computed Flow
p1 = 1.5;
p2 = p1-DeltaP;
Q_G = C_d * (pi*(d0^2)/4) * p1 * sqrt(2*xi/(xi-1) * g/(R*T1) * ((p2/p1)^(2/xi) - (p2/p1)^((xi+1)/xi)))