#!/bin/bash
proj_name="CL"
proj_tests="${proj_name}.Tests"
cd "$proj_tests"
dotnet test
cd ..