<!-- navigation -->
<div class="navigation">
    <a href="<?php echo base_url(); ?>">Home</a>
    <a href="<?php echo base_url('livre/add');?>">Ajouter</a>
    </br>
    </br>
    
    
<?php
echo validation_errors();
echo form_open(base_url('livre/rechercher'));
echo form_label('Rechercher :', 'rechercher');
echo form_input('titre');
echo form_submit('valider', 'Rechercher');
echo form_close();
?>
    </br>
<?php
        if (count($livres) > 1)
        {
            echo "Il y a ";
            echo count($livres);
            echo " livres";
        }
        if (count($livres) == 0)
        {
            echo "Il n'y a aucun livre";
        }
        if (count($livres) == 1)
        {
            echo "Il y a 1 livre";
        }
        ?>
    </br>
    </br>    

</div>
<?php 
echo $links;
?>
<table>
    <tr>
        <td>id</td>
        <td>titre</td>
        <td>couverture</td>
        <td>id auteur</td>
        <td>id editeur</td>
        <td>id quizz</td>
        <td>image</td>
        <td>Actions</td>
    </tr>
    
    <?php
    foreach($livres as $l):
        
        if($l['id']%2 == 1)
        {
            echo ' <tr style="background-color:rgb(210,110,0);" > ';
        }
        else
        {
            echo ' <tr style="background-color:rgb(0,180 ,228);" > ';
        }
        ?>
        
            <td><?php echo $l['id']; ?></td>
            <td><?php echo $l['titre']; ?></td>
            <td><?php echo $l['couverture']; ?></td>
            <td><?php echo $l['idAuteur']; ?></td>
            <td><?php echo $l['idEditeur']; ?></td>
            <td><?php echo $l['idQuizz']; ?></td>
            <td><img src="<?php echo base_url('img/'.$l['couverture']) ?>" alt="<?php echo $l['titre']; ?>" height="50" width="50"> </td>
            <td>
                <a href="<?php echo site_url('livre/edit/'.$l['id']); ?>">Edit</a> | 
                <a href="<?php echo site_url('livre/remove/'.$l['id']); ?>">Delete</a>
            </td>
        </tr>
    <?php endforeach;
    
    ?>
        
</table>
<?php
echo $links;
?>