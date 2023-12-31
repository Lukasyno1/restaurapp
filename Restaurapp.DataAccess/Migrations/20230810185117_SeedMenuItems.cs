﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurapp.DataAccess.Migrations
{
    public partial class SeedMenuItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Fish', 10, 15, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Sausage', 10, 22, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Bacon', 10, 8, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Egg', 10, 5, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Pasta', 10, 13, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Apple', 10, 1, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Banana', 10, 2, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Orange', 10, 3, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Pear', 10, 4, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Pineapple', 10, 5, '');");

            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Pepsi', 20, 2, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Ice tea', 20, 3, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Water', 20, 4, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Milk', 20, 5, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Lemonade', 20, 6, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Cacao', 20, 2, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Milkshake', 20, 3, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Sprite', 20, 4, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Fanta', 20, 5, '');");
            migrationBuilder.Sql("INSERT INTO public.\"MenuItems\"\r\n(\"Id\", \"Name\", \"Category\", \"Price\", \"ImageFileName\")\r\nVALUES(gen_random_uuid(), 'Beer', 20, 6, '');");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
