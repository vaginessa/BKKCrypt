#!/bin/bash

source /home/daroczig/.scripts/R/setvars.sh
bash install.sh

echo
echo Testing package...

Rscript --vanilla -e "library(testthat);suppressWarnings(suppressPackageStartupMessages(library(BKKCrypt)));test_package('BKKCrypt')"
