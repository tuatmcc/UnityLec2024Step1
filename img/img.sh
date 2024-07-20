#!/bin/bash

for file in *.png; do
  filename="${file%.*}"
  convert "$file" "$filename.webp"
  echo "Converted $file to $filename.webp"
done